using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Auctions.Models.Database;
using Auctions.Models.View;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace Auctions.Controllers {
    public class UserController : Controller {

        private AuctionsContext context;
        private UserManager<User> user_manager;
        private IMapper mapper;
        private SignInManager<User> sign_in_manager;

        public UserController(AuctionsContext context, UserManager<User> user_manager, IMapper mapper, SignInManager<User> sign_in_manager) {
            this.context = context;
            this.user_manager = user_manager;
            this.mapper = mapper;
            this.sign_in_manager = sign_in_manager;
        }

        public IActionResult isEmailUnique(string email) {
            bool exists = context.Users.Where(user => user.Email == email).Any();

            if(exists) {
                return Json("Email already taken!");
            } else {
                return Json(true);
            }
        }

        public IActionResult isUsernameUnique(string username) {
            bool exists = context.Users.Where(user => user.UserName == username).Any();

            if(exists) {
                return Json("Username already taken!");
            } else {
                return Json(true);
            }
        }

        public IActionResult Register() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model) {
            if(!ModelState.IsValid) {
                return View ( model );
            }

            User user = mapper.Map<User>(model);
            
            IdentityResult result = await user_manager.CreateAsync(user, model.password);

            if(!result.Succeeded) {
                foreach(IdentityError error in result.Errors) {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }

            result = await user_manager.AddToRoleAsync(user, Roles.user.Name);

            if(!result.Succeeded) {
                foreach(IdentityError error in result.Errors) {
                    ModelState.AddModelError("", error.Description);
                }

                return View(model);
            }

            return RedirectToAction(nameof(UserController.LogIn), "User");
        }

        public IActionResult LogIn(string return_url) {
           LogInModel model = new LogInModel() {
               return_url = return_url
           };
           return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LogInModel model) {
            if(!ModelState.IsValid) {
                return View(model);
            }

            var result = await sign_in_manager.PasswordSignInAsync(model.username, model.password, false, false);

            if(!result.Succeeded) {
                ModelState.AddModelError("", "Username or password not valid!");
                return View(model);
            }

            if(model.return_url != null) {
                return Redirect(model.return_url);
            }
            
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOut() {
            await sign_in_manager.SignOutAsync();
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> EditUserProfile(string id) {
            var user = await user_manager.FindByIdAsync(id);

            EditUserModel model = new EditUserModel() {
                id = user.Id,
                username = user.UserName,
                gender = user.gender,
                email = user.Email,
                first_name = user.first_name,
                last_name = user.last_name
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUserProfile(EditUserModel model) {
            if(model == null) {
                return NotFound();
            }

            if(!ModelState.IsValid) {
                return View(model);
            }

            var user = await user_manager.FindByIdAsync(model.id);

            if(user == null) {
                return NotFound();
            }

            user.first_name = model.first_name;
            user.last_name = model.last_name;
            user.gender = model.gender;
            
            await user_manager.UpdateAsync(user);

            var result = await user_manager.SetUserNameAsync(user, model.username);

            if(!result.Succeeded) {
                foreach(var error in result.Errors) {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            result = await user_manager.SetEmailAsync(user, model.email);

            if(!result.Succeeded) {
                foreach(var error in result.Errors) {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }

            if(model.new_password != null) {
                if (!model.new_password.Any(char.IsDigit)) {
                    ModelState.AddModelError("","New Password must contain a digit");
                    return View();
                }

                if (model.current_password == null) model.current_password = "";

                result = await user_manager.ChangePasswordAsync(user, model.current_password, model.new_password);

                if(!result.Succeeded) {
                    foreach(var error in result.Errors) {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View();
                }
            }
            
            await sign_in_manager.RefreshSignInAsync(user);

            TempData["action"] = "User Profile successfully updated!";

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [Authorize(Roles = "User")]
        public IActionResult CreateAuction() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAuction(EditAuctionModel model) {
            if(!ModelState.IsValid) {
                return View(model);
            }

            User user = await user_manager.GetUserAsync(base.User);

            if(model.opens_at > model.closes_at) {
                ModelState.AddModelError("", "Auction must open before it is closed!");
                return View(model);
            }

            DateTime opens_at = new DateTime(model.opens_at.Year, model.opens_at.Month, model.opens_at.Day,
                                             model.opens_at.Hour, model.opens_at.Minute, model.opens_at.Second);

            DateTime closes_at = new DateTime(model.closes_at.Year, model.closes_at.Month, model.closes_at.Day,
                                             model.closes_at.Hour, model.closes_at.Minute, model.closes_at.Second);

            using ( BinaryReader reader = new BinaryReader(model.image.OpenReadStream())) {
                Auction auction = new Auction()
                {
                    name = model.name,
                    description = model.description,
                    image = reader.ReadBytes( Convert.ToInt32(reader.BaseStream.Length)),
                    created_at = DateTime.Now,
                    opens_at = opens_at,
                    closes_at = closes_at,
                    starting_price = model.starting_price,
                    user_id = user.Id
                };

                await context.auctions.AddAsync(auction);
                await context.SaveChangesAsync();
            }
            TempData["button"] = "success";
            TempData["action"] =string.Format("{0} successfully created!", model.name);

            return RedirectToAction(nameof(UserController.MyAuctions), "User");
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> EditAuction(int id) {
            var auction = await context.auctions
                                    .Where(auction => auction.id == id).FirstOrDefaultAsync();

            EditAuctionModel model = new EditAuctionModel() {
                id = auction.id,
                name = auction.name,
                description = auction.description,
                starting_price = auction.starting_price,
                opens_at = auction.opens_at,
                closes_at = auction.closes_at
            };

            TempData["editable"] = auction.state == state.DRAFT;

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditAuction(EditAuctionModel model) {
            if(model == null) {
                return NotFound();
            }

            if(!ModelState.IsValid) {
                return View(model);
            }

            var auction = await context.auctions
                            .Where(auction => auction.id == model.id).FirstOrDefaultAsync();

            auction.name = model.name;
            auction.description = model.description;

            using(BinaryReader reader = new BinaryReader(model.image.OpenReadStream())) {
                auction.image = reader.ReadBytes(Convert.ToInt32(reader.BaseStream.Length));
            }

            auction.starting_price = model.starting_price;

            if(model.opens_at > model.closes_at) {
                ModelState.AddModelError("", "Auction must be opened before it is closed!");
                return View(model);
            }

            auction.opens_at = model.opens_at;
            auction.closes_at = model.closes_at;

            context.auctions.Update(auction);
            await context.SaveChangesAsync();

            TempData["button"] = "success";
            TempData["action"] = string.Format("{0} successfully updated!", auction.name);

            return RedirectToAction(nameof(UserController.MyAuctions), "User");
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> DeleteAuction(int id) {
            var auction = context.auctions
                            .Where(auction => auction.id == id).FirstOrDefault();

            auction.state = state.DELETED;
            context.auctions.Update(auction);
            await context.SaveChangesAsync();

            TempData["button"] = "danger";
            TempData["action"] = string.Format("{0} successfully deleted!", auction.name);

            return RedirectToAction(nameof(UserController.MyAuctions), "User");
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> MyAuctions() {
            User user = await user_manager.GetUserAsync(base.User);

            var auctions = await context.auctions
                                    .Where(auction => auction.user_id == user.Id)
                                    .Where(auction => auction.state != state.DELETED)
                                    .OrderByDescending(auction => auction.created_at)
                                    .ToListAsync();
            return View(auctions);
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> WonAuctions() {
            User user = await user_manager.GetUserAsync(base.User);

            var auctions = await context.auctions
                                    .Where(auction => auction.state != state.SOLD)
                                    .Include(auction => auction.bids)
                                    .OrderByDescending(auction => auction.created_at)
                                    .ToListAsync();

            TempData["user_id"] = user.Id;

            return View(auctions);
        }

        public async Task<IActionResult> AuctionDetails(int id) {
            var auction = await context.auctions
                                    .Where(auction => auction.id == id)
                                    .FirstOrDefaultAsync();

            return View(auction);
        }
    }
}
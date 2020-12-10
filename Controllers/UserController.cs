using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Security.Claims;
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

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

        [Authorize(Roles = "User")]
        public IActionResult CreateAuction() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAuction(CreateEditAuctionModel model) {
            if(!ModelState.IsValid) {
                return View(model);
            }

            User user = await user_manager.GetUserAsync(base.User);

            if(model.opens_at > model.closes_at) {
                ModelState.AddModelError("", "Auction must open before it is closed!");
                return View(model);
            }

            DateTime opens_at = new DateTime(model.opens_at.Year, model.opens_at.Month, model.opens_at.Day,
                                             model.opens_at_time.Hour, model.opens_at_time.Minute, model.opens_at_time.Second);

            DateTime closes_at = new DateTime(model.closes_at.Year, model.closes_at.Month, model.closes_at.Day,
                                              model.closes_at_time.Hour, model.closes_at_time.Minute, model.closes_at_time.Second);
            
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

            CreateEditAuctionModel model = new CreateEditAuctionModel() {
                id = id,
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
        public async Task<IActionResult> EditAuction(CreateEditAuctionModel model) {
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

            auction.opens_at = new DateTime(model.opens_at.Year, model.opens_at.Month, model.opens_at.Day,
                                            model.opens_at_time.Hour, model.opens_at_time.Minute, model.opens_at_time.Second);

            auction.closes_at = new DateTime(model.closes_at.Year, model.closes_at.Month, model.closes_at.Day,
                                             model.closes_at_time.Hour, model.closes_at_time.Minute, model.closes_at_time.Second);
            
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
                                    .OrderByDescending(auction => auction.created_at)
                                    .ToListAsync();
            return View(auctions);
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> MyOrders() {
            int limit = 2;
            User user = await user_manager.GetUserAsync(base.User);

            var orders = await context.orders
                                    .Where(order => order.user_id == user.Id)
                                    .Take(limit)
                                    .OrderBy(order => order.date)
                                    .ToListAsync();
            
            TempData["current_page"] = 1;
            TempData["num_pages"] = (int) Math
                                            .Ceiling((double) context.orders
                                            .Where(order => order.user_id == user.Id)
                                            .Count() / limit);
            
            return View("MyOrders", orders);
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> MyOrdersPage(int page) {
            int limit = 2;
            User user = await user_manager.GetUserAsync(base.User);

            IList<Order> orders = await context.orders
                                            .Where(order => order.user_id == user.Id)
                                            .Skip((page - 1) * limit)
                                            .Take(limit)
                                            .OrderBy(order => order.date)
                                            .ToListAsync();     

            TempData["current_page"] = page;
            TempData["num_pages"] = (int) Math
                                            .Ceiling((double) context.orders
                                            .Where(order => order.user_id == user.Id)
                                            .Count() / limit);

            return PartialView("MyOrdersPartial", orders);
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> WonAuctions() {
            User user = await user_manager.GetUserAsync(base.User);

            var auctions = await context.auctions
                                    .Where(auction => auction.state == state.SOLD)
                                    .Include(auction => auction.bids).ThenInclude(bid => bid.user)
                                    .OrderByDescending(auction => auction.created_at)
                                    .ToListAsync();

            TempData["user_id"] = user.Id;

            return View(auctions);
        }

        public async Task<IActionResult> AuctionDetails(int id) {
            var auction = await context.auctions
                                    .Where(auction => auction.id == id)
                                    .Include(auction => auction.bids).ThenInclude(bid => bid.user)
                                    .FirstOrDefaultAsync();

            User user = await user_manager.GetUserAsync(base.User);
            if(user != null) {
                TempData["user_id"] = user.Id;
            } else {
                TempData["user_id"] = "";
            }

            return View(auction);
        }

        public async Task<IActionResult> GetAuctionDetails(int id) {
            var auction = await context.auctions
                                    .Where(auction => auction.id == id)
                                    .Include(auction => auction.bids).ThenInclude(bid => bid.user)
                                    .FirstOrDefaultAsync();
            
            return PartialView("AuctionDetailsPartial", auction);
        }

        [Authorize(Roles = "User")]
        public IActionResult PurchaseTokensView() {
            var model = new PurchaseTokensModel() {
                package = "SILVER : 5 tokens : $1,000.00"
            };
            return View(model);
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> PurchaseTokens(string selected_package) {
            User user = await user_manager.GetUserAsync(base.User);

            string package = selected_package;

            user.tokens += (int) Enum.Parse(typeof(Auctions.Models.Database.tokens), package);
            await user_manager.UpdateAsync(user);

            Order order = new Order() {
                package = package,
                date = DateTime.Now,
                user_id = user.Id
            };

            await context.orders.AddAsync(order);
            await context.SaveChangesAsync();

            return Ok("You have successfully made a payment!");
        }

        [Authorize(Roles = "User")]
        public int MyTokens() {
            string user_id = "";
            
            foreach(Claim claim in User.Claims) {
                if(claim.Type.Equals("id")) {
                    user_id = claim.Value;
                }
            }

            User user = context.Users
                            .Where(user => user.Id == user_id).FirstOrDefault();
            
            return user.tokens;
        }

        [Authorize(Roles = "User")]
        public async Task<IActionResult> Bid(int id) {
            User user = await user_manager.GetUserAsync(base.User);

            var transaction = await context.Database.BeginTransactionAsync();

            Auction auction = await context.auctions
                                .Where(auction => auction.id == id)
                                .Include(auction => auction.bids).ThenInclude(bid => bid.user)
                                .FirstOrDefaultAsync();

            if(auction == null) {
                await transaction.RollbackAsync();
                return BadRequest("Auction doesn't exist error!");
            }
            ICollection<Bid> bids = auction.bids;

            if(((bids.LastOrDefault() != null && bids.LastOrDefault().user_id != user.Id) || bids.LastOrDefault() == null) && user.tokens * 1000 <= auction.starting_price + auction.price_increase) {
                await transaction.RollbackAsync();
                return BadRequest("You don't have enough tokens left!");
            }
            
            if(bids.LastOrDefault() != null) {
                if(bids.LastOrDefault().user_id == user.Id) {
                    user.tokens--;
                } else {
                    bids.LastOrDefault().user.tokens += (int)((auction.starting_price + auction.price_increase) / 1000);
                    user.tokens -= (int)((auction.starting_price + auction.price_increase) / 1000) + 1;
                }
            } else {
                user.tokens -= (int)((auction.starting_price + auction.price_increase) / 1000) + 1;
            }
            auction.price_increase += 1000;

            Bid bid = new Bid() {
                user_id = user.Id,
                auction_id = id,
                time = DateTime.Now
            };

            await context.bids.AddAsync(bid);
            await context.SaveChangesAsync();
            await transaction.CommitAsync();

            return Ok("You have successfully made a bid!");
        }
    }
}
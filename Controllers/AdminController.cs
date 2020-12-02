using System;
using System.Collections.Generic;
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
    public class AdminController : Controller {
        private AuctionsContext context;
        private UserManager<User> user_manager;
        private IMapper mapper;
        private SignInManager<User> sign_in_manager;

        public AdminController(AuctionsContext context, UserManager<User> user_manager, IMapper mapper, SignInManager<User> sign_in_manager) {
            this.context = context;
            this.user_manager = user_manager;
            this.mapper = mapper;
            this.sign_in_manager = sign_in_manager;
        }

        
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Users() {
            User admin = await user_manager.GetUserAsync(base.User);

            IList<User> users = await context.Users
                                        .Where(user => user.Id != admin.Id)
                                        .Where(user => !user.is_deleted).ToListAsync();
            return View(users);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteUser(string id) {
            var user = await user_manager.FindByIdAsync(id);
            user.is_deleted = true;
            await user_manager.UpdateAsync(user);

            var auctions = await context.auctions
                                    .Where(auction => auction.user_id == id).ToListAsync();
            
            foreach(Auction auction in auctions) {
                auction.state = state.SOLD;       
                context.auctions.Update(auction);
            }
            await context.SaveChangesAsync();

            TempData["action"] = string.Format("{0} successfully deleted!", user.first_name + " " + user.last_name);

            return RedirectToAction( nameof(AdminController.Users), "Admin");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Auctions() {
            var auctions = await context.auctions
                                    .Where(auction => auction.state == state.DRAFT).ToListAsync();
            return View(auctions);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> ConfirmAuction(int id) {
            var auction = await context.auctions
                                    .Where(auction => auction.id == id).FirstOrDefaultAsync();
    
            auction.state = state.READY;       
            context.auctions.Update(auction);
            await context.SaveChangesAsync();

            TempData["button"] = "success";
            TempData["action"] = string.Format("{0} successfully confirmed!", auction.name);

            return RedirectToAction( nameof(AdminController.Auctions), "Admin");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteAuction(int id) {
            var auction = await context.auctions
                                    .Where(auction => auction.id == id).FirstOrDefaultAsync();
    
            auction.state = state.DELETED;       
            context.auctions.Update(auction);
            await context.SaveChangesAsync();

            TempData["button"] = "danger";
            TempData["action"] = "Auction successfully deleted!";

            return RedirectToAction( nameof(AdminController.Auctions), "Admin");
        }
    }
}
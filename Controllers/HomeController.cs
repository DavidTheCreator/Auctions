using System;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;
using AutoMapper;
using Auctions.Models;
using Auctions.Models.View;
using Auctions.Models.Database;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Auctions.Controllers {

    [Authorize]
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private AuctionsContext context;
        private UserManager<User> user_manager;
        private IMapper mapper;
        private SignInManager<User> sign_in_manager;

        public HomeController(ILogger<HomeController> logger, AuctionsContext context, UserManager<User> user_manager, IMapper mapper, SignInManager<User> sign_in_manager) {
            this.context = context; 
            this.user_manager = user_manager;
            this.mapper = mapper;
            this.sign_in_manager = sign_in_manager;
            _logger = logger;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index() {
            int limit = 8;

            UpdateIndex();

            var auctions = await context.auctions
                                    .Where(auction => (auction.state == state.OPEN || auction.state == state.SOLD))
                                    .Take(limit)
                                    .Include(auction => auction.bids).ThenInclude(auction => auction.user)
                                    .OrderByDescending(auction => auction.created_at)
                                    .ToListAsync();

            TempData["current_page"] = 1;
            TempData["num_pages"] = (int) Math
                                            .Ceiling((double) context.auctions
                                            .Where(auction => (auction.state == state.OPEN || auction.state == state.SOLD))
                                            .Count() / limit);

            return View("Index", auctions);
        }

        public void UpdateIndex() {
            IList<Auction> updated_auctions = context.auctions
                                        .Where(auction => (auction.state != state.EXPIRED 
                                                        && auction.state != state.SOLD 
                                                        && auction.state != state.DELETED))
                                        .Include(auction => auction.bids)
                                        .ToList();

            foreach(Auction auction in updated_auctions) {
                if(DateTime.Compare(auction.opens_at, DateTime.Now) < 0 && auction.state == state.DRAFT) {
                    auction.state = state.EXPIRED;
                } else if(DateTime.Compare(auction.opens_at, DateTime.Now) < 0 && auction.state == state.READY) {
                        auction.state = state.OPEN;
                } else if(auction.state == state.OPEN && DateTime.Compare(auction.closes_at, DateTime.Now) < 0) {
                    if(auction.bids != null) {
                        auction.state = state.SOLD;
                    } else {
                        auction.state = state.EXPIRED;
                    }
                }
                context.auctions.Update(auction);
            }
            context.SaveChanges();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Filter(FilterModel filter) {
            int limit = 8;

            IQueryable<Auction> auctions = context.auctions;
            
            if(filter.auction_name != null && filter.auction_name != "") {
                auctions = auctions
                                .Where(auction => auction.name.ToUpper()
                                .Contains(filter.auction_name.ToUpper()));
            }      

            if (filter.from_price != 0) {
                auctions = auctions
                                .Where(auction => auction.starting_price + auction.price_increase >= filter.from_price);
            }

            if(filter.to_price != 0) {
                auctions = auctions
                                .Where(auction => auction.starting_price + auction.price_increase <= filter.to_price);
            }    

            IList<Auction> auctions_ = await auctions
                                                .Where(auction => auction.state == state.OPEN || auction.state == state.SOLD)
                                                .Skip((filter.page - 1) * limit)
                                                .Include(auction => auction.bids).ThenInclude(auction => auction.user)
                                                .Take(limit)
                                                .OrderByDescending(auction => auction.created_at)
                                                .ToListAsync();

            TempData["current_page"] = filter.page;
            TempData["num_pages"] = (int) Math
                                            .Ceiling((double) auctions
                                            .Count() / limit);

            return PartialView("IndexPartial", auctions_);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

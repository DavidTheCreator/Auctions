using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Auctions.Hubs {
    class AuctionHub : Hub {
        public async Task AddToGroup(string group_id) {
            await base.Groups.AddToGroupAsync(base.Context.ConnectionId, group_id);
        }

        public async Task BidInIndex() {
            await base.Clients.All.SendAsync("UpdateIndex");
        }

        public async Task BidInAuctionDetails(string group_id) {
             await base.Clients.Group(group_id).SendAsync("UpdateAuctionDetails", group_id);
        }
    }
}
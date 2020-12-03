using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Auctions.Hubs {
    class AuctionHub : Hub {
        public async Task AddToGroup(string group_name) {
            await base.Groups.AddToGroupAsync(base.Context.ConnectionId, group_name);
        }
    }
}
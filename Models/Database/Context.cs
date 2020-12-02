using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Auctions.Models.Database {
    public class AuctionsContext : IdentityDbContext<User> {
        public DbSet<Auction> auctions { get; set; }
        public DbSet<Bid> bids { get; set; }
        public DbSet<Order> orders { get; set; }
        public AuctionsContext(DbContextOptions options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new IdentityRoleConfiguration());
            builder.ApplyConfiguration(new AuctionConfiguration());
            builder.ApplyConfiguration(new BidConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
        }
    }
}
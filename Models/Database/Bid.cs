using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Auctions.Models.Database {
    public class Bid {
        [Key]
        public int id { get; set; }
        public string user_id { get; set; }
        public User user { get; set; }
        public int auction_id { get; set; }
        public Auction auction { get; set; }
        public int tokens { get; set; }
        public DateTime time { get; set; }
    }

    class BidConfiguration : IEntityTypeConfiguration<Bid> {
        public void Configure(EntityTypeBuilder<Bid> builder) {
            builder.Property(bid => bid.id)
                .ValueGeneratedOnAdd();
            
            builder.HasOne<User>(item => item.user)
                .WithMany(item => item.bids)
                .HasForeignKey(item => new { item.user_id });

            builder.HasOne<Auction>(item => item.auction)
                .WithMany(item => item.bids)
                .HasForeignKey(item => new { item.auction_id });
        }
    }
}
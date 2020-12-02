using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Auctions.Models.Database {
    public enum state {
        DRAFT,
        READY,
        OPEN,
        SOLD,
        EXPIRED,
        DELETED
    }

    public class Auction {
        [Key]
        public int id { get; set; }
        public string user_id { get; set; }
        public User user { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }
        [Required]
        public byte[] image { get; set; }   
        [Required]
        public float starting_price { get; set; }
        public float price_increase { get; set; } = 0;
        [Required]
        public DateTime created_at { get; set; }
        [Required]
        public DateTime opens_at { get; set; }
        [Required]
        public DateTime closes_at { get; set; }
        public state state { get; set; } = state.DRAFT;
        public ICollection<Bid> bids { get; set; }
    }

    public class AuctionConfiguration : IEntityTypeConfiguration<Auction> {
        public void Configure(EntityTypeBuilder<Auction> builder) {
            builder.Property( auction => auction.id ).ValueGeneratedOnAdd();

            builder.HasOne<User>(item => item.user)
                .WithMany(item => item.auctions)
                .HasForeignKey(item => new { item.user_id });

        }
    }
}
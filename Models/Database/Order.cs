using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Auctions.Models.Database {

    public enum tokens {
        SILVER = 5,
        GOLD = 10,
        PLATINUM = 20
    }

    public enum prices {
        SILVER = 1000,
        GOLD = 1900,
        PLATINUM = 3600
    }

    public class Order {
        [Key]
        public int id { get; set; }
        [Required]
        public string user_id { get; set; }
        public User user { get; set; }
        [Required]
        public string package { get; set; } = "PLATINUM";
        public DateTime date { get; set; }
    }

    public class OrderConfiguration : IEntityTypeConfiguration<Order> {
        public void Configure(EntityTypeBuilder<Order> builder) {
            builder.Property( order => order.id ).ValueGeneratedOnAdd();

            builder.HasOne<User>(item => item.user)
                .WithMany(item => item.orders)
                .HasForeignKey(item => new { item.user_id });

        }
    }
}
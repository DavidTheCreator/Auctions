using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Auctions.Models.Database {

    public enum package {
        Silver = 0,
        Gold = 1,
        Platinum = 2
    }

    public class Order {
        [Key]
        public int id { get; set; }
        public string user_id { get; set; }
        public User user { get; set; }
        [Required]
        public int tokens { get; set; }
        [Required]
        public float price { get; set; }
        [Required]
        public package type { get; set; }
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
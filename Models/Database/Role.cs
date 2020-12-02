using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace Auctions.Models.Database {
    public static class Roles {
            public static IdentityRole user =  new IdentityRole() {
              Name = "User",
              NormalizedName = "USER"   
            };
            public static IdentityRole admin =  new IdentityRole() {
              Name = "Admin",
              NormalizedName = "ADMIN"   
            };
        }
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole> {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder) {
            builder.HasData(
                Roles.user,
                Roles.admin
            );
        }
    }
}
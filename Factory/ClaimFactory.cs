using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Auctions.Models.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;

namespace Auctions.Factories {
    public class ClaimFactory : UserClaimsPrincipalFactory<User> {
        private UserManager<User> user_manager;
        public ClaimFactory(UserManager<User> user_manager, IOptions<IdentityOptions> options_accessor) : base(user_manager, options_accessor) {
            this.user_manager = user_manager;
        }

        public override Task<ClaimsPrincipal> CreateAsync(User user) { return base.CreateAsync(user); }

        public override bool Equals(object obj) { return base.Equals(obj); }

        public override int GetHashCode() { return base.GetHashCode(); }

        public override string ToString() { return base.ToString(); }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user) {
            ClaimsIdentity claims_identity = await base.GenerateClaimsAsync(user);

            claims_identity.AddClaim(
                new Claim("id", user.Id)
            );

            claims_identity.AddClaim(
                new Claim("full_name", user.first_name + " " + user.last_name)
            );

            claims_identity.AddClaim(
                new Claim("tokens", user.tokens.ToString())
            );

            IList<string> roles = await this.user_manager.GetRolesAsync(user);

            foreach(string role in roles) {
                claims_identity.AddClaim(
                    new Claim(ClaimTypes.Role, role)
                );
            }

            return claims_identity;
        }
    }
}
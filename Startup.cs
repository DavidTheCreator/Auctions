using AutoMapper;
using Auctions.Hubs;
using Auctions.Factories;
using Auctions.Models.Database;
using Auctions.Models.Initializers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Auctions {
    public class Startup {
        public Startup(IConfiguration configuration) {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services) {

            services.AddDbContext<AuctionsContext>(
                options => {
                    options.UseMySql(Configuration.GetConnectionString("AuctionsDB"));
                }
            );

            services.AddIdentity<User, IdentityRole>(
                options=> {
                    options.User.RequireUniqueEmail = true;
                    options.Password.RequireDigit = true;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireNonAlphanumeric = false;
                    options.Password.RequiredLength = 8;
                }
            ).AddEntityFrameworkStores<AuctionsContext>();

            services.AddRazorPages()
                    .AddRazorRuntimeCompilation();

            services.AddAutoMapper(typeof(Startup));

            services.ConfigureApplicationCookie (
                options => {
                    options.LoginPath = "/User/LogIn";
                    options.AccessDeniedPath = "/Home/Error";
                }
            );

            services.AddScoped<IUserClaimsPrincipalFactory<User>, ClaimFactory> ( );

            services.AddSignalR ( );

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<User> user_manager) {
            if (env.IsDevelopment()) {
                UserInitializer.initialize(user_manager);
                app.UseDeveloperExceptionPage();
            }
            else {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapHub<AuctionHub>("/update");
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseCookiePolicy();
        }
    }
}

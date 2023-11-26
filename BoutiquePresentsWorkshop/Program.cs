using BoutiquePresentsWorkshop.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using Microsoft.Identity.Client;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
//using BoutiquePresentsWorkshop.Repositories;

namespace BoutiquePresentsWorkshop
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services
                .AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultUI()
                .AddDefaultTokenProviders();
                
            builder.Services.AddRazorPages();
            //builder.Services.AddTransient<IHomeRepository, HomeRepository>();
           // builder.Services.AddTransient<ICartRepository, CartRepository>();
           // builder.Services.AddTransient<IUserOrderRepository, UserOrderRepository>();
            
            var app = builder.Build();
            
            // Configure the HTTP request pipeline.
           
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
           

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

          
            app.MapControllerRoute(
            name: "areas",
            pattern: "{area=Admin}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.MapRazorPages();
            //await DbSeeder.SeedDefaultData(app.Services);

            using(var scope = app.Services.CreateScope())
            {    
                await DbSeeder.SeedDefaultData(scope.ServiceProvider);
            }

            app.Run();
        }
    }
}

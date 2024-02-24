using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Mvc_Day4.Areas.Identity.Data;
using Mvc_Day4.Utilities;
using System.Security.Claims;

namespace Mvc_Day4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("IdentityContextConnection") ?? throw new InvalidOperationException("Connection string 'IdentityContextConnection' not found.");

            builder.Services.AddDbContext<IdentityContext>(options => options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true).AddRoles<IdentityRole>().AddEntityFrameworkStores<IdentityContext>();

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //Authorization
            builder.Services.AddAuthorization(options =>{

                options.AddPolicy("Employeeone", policy=>policy.RequireClaim("EmployeeNumber"));


            });
            builder.Services.AddAuthorization(options => {

                options.AddPolicy("Admin", policy => policy.RequireRole("Adminstration"));
                options.AddPolicy("Manager", policy => policy.RequireRole("Manager"));
                options.AddPolicy("User", policy => policy.RequireRole("User"));
                options.AddPolicy("Med-Manager", policy => policy.RequireRole("Med-Manager"));



            });

            //Auto Mapper Register
            builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapRazorPages();
            app.Run();
        }
    }
}
using System;
using Authapp.Areas.Identity.Data;
using Authapp.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Authapp.Areas.Identity.IdentityHostingStartup))]
namespace Authapp.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<AuthappDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthappDbContextConnection")));

                services.AddDefaultIdentity<AuthappUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AuthappDbContext>();

                //services.AddDefaultIdentity<AuthappUser>(options => {
                //    options.Password.RequireLowercase = false;
                //    options.Password.RequireUppercase = false;
                //    options.SignIn.RequireConfirmedAccount = false;
                //})
                //.AddEntityFrameworkStores<AuthappDbContext>();
            });
        }
    }
}
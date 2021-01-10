using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WebBanking.Web.Areas.Identity.Data;
using WebBanking.Web.Data;

[assembly: HostingStartup(typeof(WebBanking.Web.Areas.Identity.IdentityHostingStartup))]
namespace WebBanking.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<WebContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("WebContextConnection")));

                services.AddDefaultIdentity<WebUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<WebContext>();
            });
        }
    }
}
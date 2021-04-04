using System;
using Dogo.Areas.Identity.Data;
using Dogo.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Dogo.Areas.Identity.IdentityHostingStartup))]
namespace Dogo.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<DogoContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("DogoContextConnection")));

                services.AddDefaultIdentity<DogoUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<DogoContext>();
            });
        }
    }
}
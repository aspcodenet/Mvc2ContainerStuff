using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mvc2DemoDay1.Data;

[assembly: HostingStartup(typeof(Mvc2DemoDay1.Areas.Identity.IdentityHostingStartup))]
namespace Mvc2DemoDay1.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Mvc2DemoDay1Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Mvc2DemoDay1ContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<Mvc2DemoDay1Context>();
            });
        }
    }
}
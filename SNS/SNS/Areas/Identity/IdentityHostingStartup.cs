using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SNS.Areas.Identity.Data;
using SNS.Data;

[assembly: HostingStartup(typeof(SNS.Areas.Identity.IdentityHostingStartup))]
namespace SNS.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SNSContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SNSContextConnection")));

                services.AddDefaultIdentity<SNSUser>()
                    .AddEntityFrameworkStores<SNSContext>();
            });
        }
    }
}
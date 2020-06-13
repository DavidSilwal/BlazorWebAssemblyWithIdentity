using System;
using BlazorWebAssemblyWithIdentity.Server.Data;
using BlazorWebAssemblyWithIdentity.Server.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(BlazorWebAssemblyWithIdentity.Server.Areas.Identity.IdentityHostingStartup))]
namespace BlazorWebAssemblyWithIdentity.Server.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
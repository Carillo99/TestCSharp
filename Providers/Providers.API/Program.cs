﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Providers.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            return WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseIISIntegration()
                .UseUrls("http://localhost:2000");
        }
    }
}
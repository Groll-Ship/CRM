using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using data;
using data.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Api.WebApplication4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ApplicationContext applicationContext = new ApplicationContext();
            //applicationContext.Database.Migrate();
            // applicationContext.Database.EnsureCreated();
          
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

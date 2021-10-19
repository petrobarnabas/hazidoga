using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elektronikaiszakuzletwebshop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            new Service.Impl.LaptopServiceImpl(new Repository.LaptopRepository());
            new Service.Impl.LaptopServiceImpl(new Repository.LaptopRepository());
            new Service.Impl.LaptopServiceImpl(new Repository.LaptopRepository());
            new Service.Impl.LaptopServiceImpl(new Repository.LaptopRepository());
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

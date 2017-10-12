using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace razor
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                // .ConfigureAppConfiguration(configBuilder => {
                //     configBuilder.AddJsonFile("appsettings.json");
                // })
                // .ConfigureLogging((context, loggerFactory) => {
                //     loggerFactory.AddConfiguration(context.Configuration);
                //     loggerFactory.AddConsole();
                //     loggerFactory.AddDebug();
                // })
                .Build();
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace CSUsingEFDBFirstWithNetCore
{
    public class Program
    {
        public static void Main(string[] args)
        {

	    var config = new ConfigurationBuilder()
    		.AddCommandLine(args)
    		.Build();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
		.UseConfiguration(config)
                //.UseIISIntegration()
                .UseStartup<Startup>()
		//.UseUrls("http://*:4000")
                .Build();

            host.Run();
        }
    }
}

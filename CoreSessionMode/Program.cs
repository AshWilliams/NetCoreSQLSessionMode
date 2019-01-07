using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace CoreSessionMode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Fortunately, there are several ways to configure endpoints for Kestrel server. 
        /// A common method is to add the .UseUrls() command to the WebHost 
        /// configuration in Program.cs: 
        /// https://docs.microsoft.com/es-es/aspnet/core/fundamentals/servers/kestrel?view=aspnetcore-2.2#when-to-use-kestrel-with-a-reverse-proxy
        /// https://www.telerik.com/blogs/configuring-kestrel-in-asp-net-core-2-1
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls("http://*:80");
    }
}

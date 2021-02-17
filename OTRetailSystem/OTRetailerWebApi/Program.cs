using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;

namespace OTRetailerWebApi
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUrl = "http://localhost:8080";
            var config = new HttpSelfHostConfiguration(baseUrl);

            config.Routes.MapHttpRoute(
               name: "API",
               routeTemplate: "{controller}/{action}/{id}",
                defaults: new
                {
                    id = RouteParameter.Optional
                });


            using (HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.WriteLine($"Server start at {baseUrl}");
                Console.WriteLine("Press any key to quit...");
                Console.ReadLine(); 
            }

        }
    }
}

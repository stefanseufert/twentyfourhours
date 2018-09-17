using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyFourHours.Web
{
    class Program
    {
        static void Main(string[] args)
        {
            var url = ConfigurationManager.AppSettings["url"];
            using (WebApp.Start<Startup.Owin>(url))
            {
                Console.WriteLine($"Programm is running, point your browser to {url}");
                Process.Start(url.Replace("://+", "://localhost"));
                Console.ReadLine();
            }
        }
    }
}

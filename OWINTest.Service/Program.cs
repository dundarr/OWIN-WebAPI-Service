using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace OWINTest.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            /*
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new APIServiceTest() 
            };
            ServiceBase.Run(ServicesToRun);
            */
            WebApp.Start("http://localhost:9000");

            Console.WriteLine("Server Started...Press any key to exit");

            Console.ReadLine();
        }
    }
}

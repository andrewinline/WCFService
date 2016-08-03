using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;


namespace WCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFService.CalculatorService)))
            {

                host.Open();
                Console.WriteLine("The service is running...");
                Console.ReadLine();
            }


            
            
            
        }
    }
}

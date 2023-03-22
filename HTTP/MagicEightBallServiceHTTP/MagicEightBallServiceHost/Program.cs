using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicEightBallServiceLib;
using System.ServiceModel;

namespace MagicEightBallServiceHost
{
    internal class Program
    {
        static void DisplayHostlnfо(ServiceHost host)
        {
            Console.WriteLine();
            Console.WriteLine("***** Host Info *****");
            foreach (System.ServiceModel.Description.ServiceEndpoint se
            in host.Description.Endpoints)
            {
                Console.WriteLine("Address: {0}", se.Address); // Адрес
                Console.WriteLine("Binding: {0}", se.Binding.Name); // Привязка
                Console.WriteLine("Contract: {0}", se.Contract.Name); // Контракт
                Console.WriteLine();
            }
            Console.WriteLine("**********************");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*****Console Based WCF Host *****");
            using (ServiceHost serviceHost = new ServiceHost(typeof(MagicEightBallService)))
            {
                // Открыть хост и начать прослушивание входящих сообщений.
                serviceHost.Open();
                // Оставить службу функционирующей до тех пор,
                // пока не будет нажата клавиша <Enter>.
                Console.WriteLine("The service is ready.");
                Console.WriteLine("Press the Enter key to terminate service.");
                DisplayHostlnfо(serviceHost);
                Console.ReadLine();
            }
            
                
            }
    }
}

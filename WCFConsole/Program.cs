using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;


    class Program
    {
        static void Main(string[] args)
        {
           Uri adres = new Uri("http://localhost:2222/Hello");

           ServiceHost host = new ServiceHost(typeof(FirstWcfcs), adres);

           host.AddServiceEndpoint(typeof(IMyWcf), new BasicHttpBinding(), adres);
           host.Open();
           Console.WriteLine("Serwer uruchomiony");
           Console.ReadLine();

        }
    }


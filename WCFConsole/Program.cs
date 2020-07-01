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
           Uri adres = new Uri("http://localhost:2222/CrmWcf");

           ServiceHost host = new ServiceHost(typeof(FirstWcfcs), adres);
           host.AddServiceEndpoint(typeof(IMyWcf), new BasicHttpBinding(), adres);

           host.Open();
           Console.WriteLine("Serwer uruchomiony");
           Console.ReadLine();

     }

    /*
     *  ServiceHost host = new ServiceHost(typeof(ContainerSvc));
        var wsBinding = new BasicHttpBinding();
        host.AddServiceEndpoint(typeof(IContainerSvc),
            wsBinding, "http://localhost:8000/ContainerSvc");
        host.Open();
        Console.WriteLine("Listening...");
        Console.ReadLine();
        host.Close();
        */


    }


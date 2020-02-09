using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {

            ServiceHost svc = new ServiceHost(typeof(Kalkulator));
            svc.AddServiceEndpoint(typeof(IKalkulator),
                                   new NetTcpBinding(),
                                   new Uri("net.tcp://localhost:4000/IKalkulator"));
            svc.Open();

            Console.ReadKey();
        }
    }
}

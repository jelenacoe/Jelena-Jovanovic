using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IKalkulator> factory = new ChannelFactory<IKalkulator>(new NetTcpBinding(),
                                                                                new EndpointAddress("net.tcp://localhost:4000/IKalkulator"));
            IKalkulator kalkulator = factory.CreateChannel();

            KompleksanBroj zbir = kalkulator.Saberi(new KompleksanBroj(5,6),new KompleksanBroj(7,8));

            Console.WriteLine(zbir);

            KompleksanBroj kolicnik;

            try
            {
                kolicnik = kalkulator.Podeli(new KompleksanBroj(4, 6), new KompleksanBroj(2, 0));
                Console.WriteLine(kolicnik);
            }
            catch(FaultException<DeljenjeNulomIzuzetak> ex)
            {
                Console.WriteLine(ex.Detail.Razlog);
            }

            try
            {
                kolicnik = kalkulator.Podeli(new KompleksanBroj(4, 6), new KompleksanBroj(0, 0));
                Console.WriteLine(kolicnik);
            }
            catch (FaultException<DeljenjeNulomIzuzetak> ex)
            {
                Console.WriteLine(ex.Detail.Razlog);
            }

            Console.ReadKey();
        }
    }
}

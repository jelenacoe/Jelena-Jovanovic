using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Common;

namespace Server
{
    class Kalkulator : IKalkulator
    {
        public KompleksanBroj Oduzmi(KompleksanBroj a, KompleksanBroj b)
        {
            return KompleksanBroj.Oduzmi(a, b);
        }

        public KompleksanBroj Pomnozi(KompleksanBroj a, KompleksanBroj b)
        {
            return KompleksanBroj.Pomnozi(a, b);
        }

        public KompleksanBroj Saberi(KompleksanBroj a, KompleksanBroj b)
        {
            return KompleksanBroj.Saberi(a, b);
        }

        public KompleksanBroj Podeli(KompleksanBroj a, KompleksanBroj b)
        {
            KompleksanBroj povratnaVrednost;

            try
            {
                povratnaVrednost = KompleksanBroj.Podeli(a, b);
            }
            catch(DivideByZeroException ex)
            {
                DeljenjeNulomIzuzetak deljenjeNulomIzuzetak = new DeljenjeNulomIzuzetak();
                throw new FaultException<DeljenjeNulomIzuzetak>(deljenjeNulomIzuzetak);
            }

            return povratnaVrednost;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Common
{
    [DataContract]
    public class KompleksanBroj
    {
        private double realanBroj;
        private double imaginaranBroj;

        public KompleksanBroj(double realanBroj, double imaginaranBroj)
        {
            this.realanBroj = realanBroj;
            this.imaginaranBroj = imaginaranBroj;

        }

        [DataMember]
        public double RealanBroj
        {
            get { return realanBroj; }
            set { realanBroj = value; }
        }

        [DataMember]
        public double ImaginaranBroj
        {
            get { return imaginaranBroj; }
            set { imaginaranBroj = value; }
        }
        public static KompleksanBroj Saberi(KompleksanBroj a, KompleksanBroj b)
        {
            double realanBroj = a.realanBroj + b.realanBroj;
            double imaginaranBroj = a.imaginaranBroj + b.imaginaranBroj;
            return new KompleksanBroj(realanBroj, imaginaranBroj);

        }
        public static KompleksanBroj Oduzmi(KompleksanBroj a, KompleksanBroj b)
        {
            double realanBroj = a.realanBroj - b.realanBroj;
            double imaginaranBroj = a.imaginaranBroj - b.imaginaranBroj;
            return new KompleksanBroj(realanBroj, imaginaranBroj);

        }
        public static KompleksanBroj Pomnozi(KompleksanBroj a, KompleksanBroj b)
        {
            double realanBroj = (a.realanBroj * b.realanBroj) - (a.imaginaranBroj * b.imaginaranBroj);
            double imaginaranBroj = (a.realanBroj * b.imaginaranBroj) + (a.imaginaranBroj * b.realanBroj);
            return new KompleksanBroj(realanBroj, imaginaranBroj);

        }
        public static KompleksanBroj Podeli(KompleksanBroj a, KompleksanBroj b)
        {
            KompleksanBroj k = new KompleksanBroj(b.realanBroj, b.imaginaranBroj * -1);
            KompleksanBroj brojilac = KompleksanBroj.Pomnozi(a, k);
            KompleksanBroj imenilac = KompleksanBroj.Pomnozi(b, k);

            if(imenilac.realanBroj == 0)
            {
                throw new DivideByZeroException();
            }

            double realanBroj = brojilac.realanBroj / imenilac.realanBroj;
            double imaginaranBroj = brojilac.imaginaranBroj / imenilac.realanBroj;
            return new KompleksanBroj(realanBroj, imaginaranBroj);
        }
        public override string ToString()
        {
            if(imaginaranBroj < 0)
                return string.Format(realanBroj + " " + imaginaranBroj + "i");
            return string.Format(realanBroj + " + " + imaginaranBroj + "i");
        }

    }
}

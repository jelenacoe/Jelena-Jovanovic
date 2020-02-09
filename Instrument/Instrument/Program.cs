using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrument
{
    class Boja
    {
        private string boja;
        public Boja(string boja)
        {
            this.boja = boja;
        }
        public string Bojaa
        {
            get { return boja; }
            set { boja = value; }
        }
        
    }
    class ZicaniInstrument
    {
        private int brZica;
        private Boja boja;
        public ZicaniInstrument(int brZica,Boja boja)
        {
            this.brZica = brZica;
            this.boja = boja;
             
        }
        public int BrojZica
        {
            get { return brZica; }
            set
            {
                if (brZica == 1)
                {
                    Console.WriteLine("Greska!");
                }
                else
                    brZica = value;
            }
        }
        public void Ispis()
        {
            Console.WriteLine("Broj zica: " + brZica);
            Console.WriteLine("Boja: " + boja.Bojaa);
        }

    }
    class Gitara : ZicaniInstrument
    {
        private string vrsta;
        private string marka;
        public Gitara(string vrsta,string marka, int brZica, Boja boja) : base(brZica, boja)
        {
            this.vrsta = vrsta;
            this.marka = marka;
        }
        public string Vrsta
        {
            get { return vrsta; }
            set
            {
                if (vrsta == " ")
                    Console.WriteLine("Greska!!");
                else
                    vrsta = value;
            }

        }
        public void Ispis()
        {
            base.Ispis();
            Console.WriteLine("Vrsta gitare je:" + vrsta);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Gitara g1 = new Gitara("Elektricna", "Fender", 6, new Boja("Crna"));
            Gitara g2 = new Gitara("Bas", "Yamaha", 4, new Boja("Crvena"));
            Gitara g3 = new Gitara("Akusticna", "Ibanez", 6, new Boja("Plava"));

            g1.Ispis();
            g2.Ispis();
            g3.Ispis();

            g3.Vrsta = "Elektricna";
            g3.Ispis();
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Úkol_ITVP
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
     class Auto
    {
        public int PocetKol { get; set; }
        public string Znacka { get; set; }
        public int PocetSedacek { get; set; }
        public double Zrychleni { get; set; }

        public double VypocetSpotreby()
        {
            double S;
            S = Zrychleni * 0.1;
            return S;
        }
        public virtual void ToString()
        {
            Console.WriteLine("Auto zrychlí z 0 na 100 Km/h za" + " " + Zrychleni);
        }

        public Auto(int pocetkol, string znacka, int pocetsedacek, double zrychleni)
        {
            pocetkol = PocetKol;
            znacka = Znacka;
            pocetsedacek = PocetSedacek;
            zrychleni = Zrychleni;
        }

    }
    class Kombi : Auto
    {
        public double VekiostKufru { get; set; }
        public override void ToString()
        {
            Console.WriteLine("Velikost kufru je "+VekiostKufru);
        }

        public Kombi(Auto a, double velikostkufru) : base (a.PocetKol, a.Znacka, a.PocetSedacek, a.Zrychleni)
        {
            PocetKol = a.PocetKol;
            Znacka = a.Znacka;
            PocetSedacek = a.PocetSedacek;
            Zrychleni = a.Zrychleni;
            velikostkufru = VekiostKufru;
        }
    }

     class Sedan : Auto
    {
        public string Barva { get; set; }
        public override void ToString()
        {
            Console.WriteLine("Vaše auto má " + Barva + " barvu");
        }
        public  Sedan(Auto b, string barva) : base(b.PocetKol, b.Znacka, b.PocetSedacek, b.Zrychleni)
        {
            PocetKol = b.PocetKol;
            Znacka = b.Znacka;
            PocetSedacek = b.PocetSedacek;
            Zrychleni = b.Zrychleni;
            barva = Barva;
        }
        
    }

}

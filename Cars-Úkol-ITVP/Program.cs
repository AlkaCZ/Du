using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars_Úkol_ITVP
{

    class Program
    {
        Random r = new Random(30);
        public string ID()
        {
            int rand = r.Next();
            string name = rand.ToString();
            return name;
        }

        static void Main(string[] args)
        {
            bool JeHra = true;
            Auto[] Garage = new Auto[30];
            int cars = 0;
            int i = 0;

           


                Console.WriteLine("Ahoj, výtej");
                Console.WriteLine("Podívej se kolik máš aut příkazem : cars");
                if (Console.ReadLine() == "cars")
                {
                    Console.WriteLine(cars);
                }
            else
            {
                JeHra = false;
            }
            Console.WriteLine("Pokud souhlasíte napište > OK");
            if (Console.ReadLine() == "OK")
            {
                Console.Clear();
                Console.WriteLine("Začni si přidávat nová auta příkazem : addcar");
                Console.WriteLine("Ale pozor máš místo jen na 30 aut");
            }
            else
            {
                JeHra = false;
            }



            while (JeHra)
            {
                if (30 > i)
                {
                    if (Console.ReadLine() == "addcar")
                    {
                        Auto ID = new Auto();
                        Garage[i] = ID;
                        ID.TEST();
                        i++;
                        cars++;
                    }
                    else
                    {
                        Console.WriteLine("Máte : " + cars + " aut");
                        JeHra = false;
                    }
                }
                else
                {
                    Console.WriteLine("Máte plnou garáž");
                    JeHra = false;
                }
               
            }   
            Console.ReadKey();
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
        public void TEST()
        {
            Console.WriteLine("Car Added");
        }
        public Auto()
        {
            PocetKol = 4;
            Znacka = "nedefinovana";
            PocetSedacek = 5;
            Zrychleni = 20.6;
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

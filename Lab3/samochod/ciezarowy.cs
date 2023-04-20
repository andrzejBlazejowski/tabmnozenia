using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.samochod
{
    public class Ciezarowy : Samochod
    {
        public static int LiczbaCiezarowych { get; private set; }
        public double Ladownosc { get; set; }
        public double MasaPrzyczepy { get; set; }

        public Ciezarowy(string marka, double pojemnoscSilnika, int przebieg, string wlasciciel, double ladownosc, double masaPrzyczepy)
            : base(marka, pojemnoscSilnika, przebieg, wlasciciel)
        {
            Ladownosc = ladownosc;
            MasaPrzyczepy = masaPrzyczepy;
        }

        public new void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Ladownosc: {0}", Ladownosc);
            Console.WriteLine("Masa przyczepy: {0}", MasaPrzyczepy);
            LiczbaCiezarowych++;
        }
    }
}

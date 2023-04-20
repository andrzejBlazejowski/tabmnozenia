using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.samochod
{
    public class Osobowy : Samochod
    {
        public static int LiczbaOsobowych { get; private set; }
        public int LiczbaMiejsc { get; set; }
        public int PredkoscMaksymalna { get; set; }

        public Osobowy(string marka, double pojemnoscSilnika, int przebieg, string wlasciciel, int liczbaMiejsc, int predkoscMaksymalna)
            : base(marka, pojemnoscSilnika, przebieg, wlasciciel)
        {
            LiczbaMiejsc = liczbaMiejsc;
            PredkoscMaksymalna = predkoscMaksymalna;
            LiczbaOsobowych++;
        }

        public new void Wypisz()
        {
            base.Wypisz();
            Console.WriteLine("Liczba miejsc: {0}", LiczbaMiejsc);
            Console.WriteLine("Predkosc maksymalna: {0}", PredkoscMaksymalna);
        }
    }
}

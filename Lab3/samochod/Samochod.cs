
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.samochod
{
    public class Samochod
    {

        public static int LiczbaSamochodow { get; private set; }
        public string Marka { get; set; }
        public double PojemnoscSilnika { get; set; }
        public int Przebieg { get; set; }
        public string Wlasciciel { get; set; }

        public Samochod(string marka, double pojemnoscSilnika, int przebieg, string wlasciciel)
        {
            Marka = marka;
            PojemnoscSilnika = pojemnoscSilnika;
            Przebieg = przebieg;
            Wlasciciel = wlasciciel;
            LiczbaSamochodow++;
        }

        public void Wypisz()
        {
            Console.WriteLine("Marka: {0}", Marka);
            Console.WriteLine("Pojemnosc silnika: {0}", PojemnoscSilnika);
            Console.WriteLine("Przebieg: {0}", Przebieg);
            Console.WriteLine("Wlasciciel: {0}", Wlasciciel);
        }
    }
}

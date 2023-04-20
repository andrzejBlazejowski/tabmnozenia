
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Pracownik
{

    public abstract class Pracownik
    {
        public string Imie { get; }
        public string Nazwisko { get; }
        public decimal[] Dochody { get; }
        private static int liczbaPracownikow;
        public static decimal SredniaPensja { get; private set; }
        public DateTime DataZatrudnienia { get; set; }
        public DateTime DataUrodzenia { get; set; }

        public Pracownik(string imie, string nazwisko, decimal[] dochody, DateTime dataUrodzenia)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Dochody = dochody;
            liczbaPracownikow++;
            SredniaPensja = ((SredniaPensja * (liczbaPracownikow - 1)) + Dochody.Sum()) / liczbaPracownikow;
            DataZatrudnienia = DateTime.Now;
            DataUrodzenia = dataUrodzenia;
        }

        public abstract decimal PensjaNetto();
        public abstract void Drukuj();

        public static int IlePracownikow()
        {
            return liczbaPracownikow;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Pracownik
{

    public class PracownikGodzinowy : Pracownik
    {
        private double stawkaGodzinowa;
        private double liczbaGodzin;

        public PracownikGodzinowy(string imie, string nazwisko, DateTime dataUrodzenia,
            double stawkaGodzinowa, double liczbaGodzin) : base(imie, nazwisko, new decimal[0], dataUrodzenia)
        {
            this.stawkaGodzinowa = stawkaGodzinowa;
            this.liczbaGodzin = liczbaGodzin;
        }

        public double ZarobekRoczny()
        {
            return stawkaGodzinowa * liczbaGodzin * 12;
        }

        public override void Drukuj()
        {
            Console.WriteLine($"Stawka godzinowa: {stawkaGodzinowa}");
            Console.WriteLine($"Liczba przepracowanych godzin: {liczbaGodzin}");
            Console.WriteLine($"Zarobek roczny: {ZarobekRoczny()}");
        }

        public override decimal PensjaNetto()
        {
            return (decimal)(liczbaGodzin * stawkaGodzinowa);
        }
    }
}

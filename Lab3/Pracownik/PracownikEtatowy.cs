using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Pracownik
{

    public class PracownikEtatowy : Pracownik
    {
        public decimal PensjaBrutto { get; }
        public decimal SkladkaEmerytalna { get; }
        public decimal SkladkaChorobowa { get; }
        public decimal SkladkaRentowa { get; }
        public decimal Podatek { get; }

        public PracownikEtatowy(string imie, string nazwisko, decimal[] dochody, decimal pensjaBrutto,
            decimal skladkaEmerytalna, decimal skladkaChorobowa, decimal skladkaRentowa, decimal podatek, DateTime dataUrodzenia)
            : base(imie, nazwisko, dochody, dataUrodzenia)
        {
            PensjaBrutto = pensjaBrutto;
            SkladkaEmerytalna = skladkaEmerytalna;
            SkladkaChorobowa = skladkaChorobowa;
            SkladkaRentowa = skladkaRentowa;
            Podatek = podatek;
        }

        public override decimal PensjaNetto()
        {
            decimal koszty = PensjaBrutto * (SkladkaEmerytalna + SkladkaChorobowa + SkladkaRentowa);
            decimal podstawa = PensjaBrutto - koszty;
            decimal podatek = Podatek * podstawa;
            decimal pensjaNetto = podstawa - podatek;
            return pensjaNetto;
        }

        public override void Drukuj()
        {
            Console.WriteLine($"Imię i nazwisko: {Imie} {Nazwisko}");
            Console.WriteLine($"Data urodzenia: {DataUrodzenia.ToShortDateString()}");
            Console.WriteLine($"Data zatrudnienia: {DataZatrudnienia.ToShortDateString()}");
            Console.WriteLine($"Pensja brutto: {PensjaBrutto:C2}");
            Console.WriteLine($"Pensja netto: {PensjaNetto():C2}");
        }
    }
}

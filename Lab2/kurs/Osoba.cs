using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.kurs
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }

        public Osoba(string imie, string nazwisko, string email)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} ({Email})";
        }
    }
}

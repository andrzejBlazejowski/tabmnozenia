using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Osoba
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public string NumerTelefonu { get; set; }
        private static int count = 0;
        public int Numer { get; set; }

        public Osoba(string imie, string nazwisko, string email, int weight, double height, string numerTelefonu)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            Weight = weight;
            Height = height;
            NumerTelefonu = numerTelefonu;
            Numer = ++count;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} ({Email})";
        }

        public double GetBMI()
        {
            return Weight / (Height * Height);
        }
    }
}

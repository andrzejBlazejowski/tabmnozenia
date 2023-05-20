using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kurs
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public int weight { get; set; }
        public double height { get; set; }

        public Osoba(string imie, string nazwisko, string email)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
        }
        public Osoba(string imie, string nazwisko, string email, int weigth, double height)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            this.weight = weigth;
            this.height = height;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} ({Email})";
        }

        public double getBMI()
        {
            return weight / (height * height);
        }
    }
}

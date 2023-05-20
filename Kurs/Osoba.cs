using System;

namespace Kurs
{
    public class Osoba
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public int Weight { get; set; }
        public double Height { get; set; }
        public Adres Adres { get; set; } 

        public Osoba(string imie, string nazwisko, string email)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
        }

        public Osoba(string imie, string nazwisko, string email, int weight, double height)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Email = email;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} ({Email})";
        }

        public double GetBMI()
        {
            return Weight / (Height * Height);
        }

        public void PrzypiszAdres(string ulica, string miasto, string kodPocztowy)
        {
            Adres = new Adres(ulica, miasto, kodPocztowy);
        }

        public void WypiszDaneZAdresem()
        {
            Console.WriteLine($"Imię: {Imie}");
            Console.WriteLine($"Nazwisko: {Nazwisko}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Adres: {Adres}");
        }
    }

    public struct Adres
    {
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string KodPocztowy { get; set; }

        public Adres(string ulica, string miasto, string kodPocztowy)
        {
            Ulica = ulica;
            Miasto = miasto;
            KodPocztowy = kodPocztowy;
        }

        public override string ToString()
        {
            return $"{Ulica}, {KodPocztowy} {Miasto}";
        }
    }
}







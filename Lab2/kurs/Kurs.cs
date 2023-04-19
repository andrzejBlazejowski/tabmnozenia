using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.kurs
{
    public class Kurs
    {
        public string Nazwa { get; set; }
        public int LiczbaGodzin { get; set; }
        public Osoba Prowadzacy { get; set; }
        public Grupa[] GrupyCwiczeniowe { get; set; }

        public Kurs(string nazwa, int liczbaGodzin, Osoba prowadzacy, Grupa[] grupyCwiczeniowe)
        {
            Nazwa = nazwa;
            LiczbaGodzin = liczbaGodzin;
            Prowadzacy = prowadzacy;
            GrupyCwiczeniowe = grupyCwiczeniowe;
        }

        public void WypiszDane()
        {
            Console.WriteLine("Kurs: " + Nazwa);
            Console.WriteLine("Liczba godzin: " + LiczbaGodzin);
            Console.WriteLine("Prowadzący: " + Prowadzacy.Imie + " " + Prowadzacy.Nazwisko);
            Console.WriteLine("Grupy ćwiczeniowe:");
            foreach (Grupa grupa in GrupyCwiczeniowe)
            {
                Console.WriteLine("- " + grupa.Nazwa);
            }
        }
    }
}

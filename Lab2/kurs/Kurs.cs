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
        public Kurs()
        {
            Console.Write("wpisz nazwę kursu: ");
            this.Nazwa = Console.ReadLine();

            Console.Write("wpisz liczbę godzin: ");
            int.TryParse(Console.ReadLine(), out int liczbaGodzin);

            Console.Write("wpisz imię prowadzącego: ");
            string imie = Console.ReadLine();
            Console.Write("wpisz nazwisko prowadzącego: ");
            string nazwisko = Console.ReadLine();
            this.Prowadzacy = new Osoba(imie, nazwisko, imie + '.' + nazwisko + "@gmail.com");

            Console.Write("wpisz liczbę grup ćwiczeniowych: ");
            int.TryParse(Console.ReadLine(), out int liczbaGrup);

            this.GrupyCwiczeniowe = new Grupa[liczbaGrup];
            for (int i = 0; i < liczbaGrup; i++)
            {
                Console.WriteLine($"Grupa {i + 1}:");
                Console.Write("wpisz grupe: ");
                string grupa = Console.ReadLine();
                Console.Write("wpisz liczbę uczestników: ");
                int.TryParse(Console.ReadLine(), out int liczbaUczestnikow);
                Console.Write("wpisz imię prowadzącego: ");
                imie = Console.ReadLine();
                Console.Write("wpisz nazwisko prowadzącego: ");
                nazwisko = Console.ReadLine();
                Osoba prowadzacyGrupy = new Osoba(imie, nazwisko, imie+'.'+nazwisko+"@gmail.com");
                this.GrupyCwiczeniowe[i] = new Grupa(grupa, liczbaUczestnikow);
            }
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

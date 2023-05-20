using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania4
{
    // Typ wyliczeniowy dla dni tygodnia
    public enum DzienTygodnia
    {
        Poniedzialek,
        Wtorek,
        Sroda,
        Czwartek,
        Piatek
    }

    // Typ wyliczeniowy dla formy zaliczenia
    public enum Zaliczenie
    {
        Zaliczenie,
        Egzamin
    }

    public struct Zajecia
    {
        public string nazwa;
        public string skrot;
        public DzienTygodnia dzien;
        public int godzina;
        public string sala;
        public Zaliczenie zal;

        // Konstruktor
        public Zajecia(string nazwa, string skrot, DzienTygodnia dzien, int godzina, string sala, Zaliczenie zal)
        {
            this.nazwa = nazwa;
            this.skrot = skrot;
            this.dzien = dzien;
            this.godzina = godzina;
            this.sala = sala;
            this.zal = zal;
        }

        // Metoda wypisująca informacje o zajęciach
        public void WypiszInformacje()
        {
            Console.WriteLine("Nazwa: {0}", nazwa);
            Console.WriteLine("Skrot: {0}", skrot);
            Console.WriteLine("Dzien: {0}", dzien);
            Console.WriteLine("Godzina: {0}", godzina);
            Console.WriteLine("Sala: {0}", sala);
            Console.WriteLine("Zaliczenie: {0}", zal);
            Console.WriteLine();
        }
    }
}

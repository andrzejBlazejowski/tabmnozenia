using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.zamowienie
{

    class Zamowienie
    {
        private DateTime dataRealizacji;
        private string nazwaKlienta;
        private Sprzedaz[] pozycjeZamowienia = new Sprzedaz[20];
        private int liczbaPozycji = 0;

        public Zamowienie(DateTime data, string klient)
        {
            dataRealizacji = data;
            nazwaKlienta = klient;
        }

        public void dodajPozycje(Sprzedaz pozycja)
        {
            pozycjeZamowienia[liczbaPozycji] = pozycja;
            liczbaPozycji++;
        }

        public void dodajPozycje(Produkt prod, int ilosc, decimal cenaJednostkowa)
        {
            Sprzedaz pozycja = new Sprzedaz(prod, ilosc, cenaJednostkowa);
            pozycjeZamowienia[liczbaPozycji] = pozycja;
            liczbaPozycji++;
        }

        public void wypiszInformacje()
        {
            Console.WriteLine("Klient: " + nazwaKlienta);
            Console.WriteLine("deadline : " + dataRealizacji.ToString());
            Console.WriteLine("Pozycje:");
            for (int i = 0; i < liczbaPozycji; i++)
            {
                Console.WriteLine("pozycja zamowienia : ");
                pozycjeZamowienia[i].wypisz();
            }
        }
    }
}


namespace Lab2.zamowienie
{
    class Sprzedaz
    {
        public string nazwa;
        public decimal cena;
        public int ilosc;

        public Sprzedaz(string n, int i, decimal c)
        {
            nazwa = n;
            ilosc = i;
            cena = c;
        }

        public void wypisz()
        {
            Console.WriteLine("Produkt: " + nazwa);
            Console.WriteLine("Cena: " + cena);
            Console.WriteLine("Ilość: " + ilosc);
        }
    }
}

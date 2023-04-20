
namespace Lab2.zamowienie
{
    public class Sprzedaz
    {
        public Produkt produkt;
        public decimal cena;
        public int ilosc;

        public Sprzedaz(Produkt n, int i, decimal c)
        {
            produkt = n;
            ilosc = i;
            cena = c;
        }

        public void wypisz()
        {
            Console.WriteLine("Produkt: " + produkt.nazwa);
            Console.WriteLine("Cena: " + cena);
            Console.WriteLine("Ilość: " + ilosc);
        }
    }
}

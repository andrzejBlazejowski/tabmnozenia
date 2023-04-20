using Lab2.kurs;
using Lab2.narzedzia;
using Lab2.wektor;
using Lab2.zamowienie;

internal class Program
{
    private static void Main(string[] args)
    {
        testujRandom();
    }
    static void testujOdcinek() 
    {
        Odcinek odcinek = new Odcinek();
        Odcinek odcinek2 = new Odcinek(2,4,1,5);
        Odcinek odcinek3 = new Odcinek(1,1,1,1);
        odcinek3.ZmianaPoczatku(2, 2);
        odcinek3.ZmianaKonca(3, 3);

        odcinek.Wypisz();
        odcinek2.Wypisz();
        odcinek3.Wypisz();
    }
    static void testujPudelko()
    {

        Pudelko pudelko1 = new Pudelko();
        pudelko1.UstawWysokosc(12.3);
        pudelko1.UstawSzerokosc(21.4);
        pudelko1.glebokosc = 1.7;
        pudelko1.Kolor = "czerwony";

        Console.WriteLine("Pudelko1");

        Console.WriteLine("wysokość: {0}, szerokosc: {1}, głębokość: {2}, kolor: {3}",
            pudelko1.DajWysokosc(),
            pudelko1.DajSzerokosc(),
            pudelko1.glebokosc,
            pudelko1.Kolor);
        Console.WriteLine();

        Pudelko pudelko2 = new Pudelko();
        pudelko2.UstawWysokosc(2.3);
        pudelko2.UstawSzerokosc(1.4);
        pudelko2.glebokosc = 6.7;
        pudelko2.Kolor = "niebieski";

        Console.WriteLine("Pudelko2");

        Console.WriteLine("wysokość: {0}, szerokosc: {1}, głębokość: {2}, kolor: {3}",
            pudelko2.DajWysokosc(),
            pudelko2.DajSzerokosc(),
            pudelko2.glebokosc,
            pudelko2.Kolor);
        Console.WriteLine();


        Pudelko pudelkoA = new Pudelko(4.2, 4.2, 5.2, "żółty");
        Console.WriteLine("PudelkoA");

        Console.WriteLine("wysokość: {0}, szerokosc: {1}, głębokość: {2}, kolor: {3}",
            pudelkoA.DajWysokosc(),
            pudelkoA.DajSzerokosc(),
            pudelkoA.glebokosc,
            pudelkoA.Kolor);
        Console.WriteLine();

        Pudelko pudelkoB = new Pudelko(pudelkoA);

        pudelkoB.glebokosc = 22222;
        pudelkoB.UstawWysokosc(22222);
        pudelkoB.UstawSzerokosc(22222);
        pudelkoB.Kolor = "czarny";

        Console.WriteLine("PudelkoB");
        Console.WriteLine("wysokość: {0}, szerokosc: {1}, głębokość: {2}, kolor: {3}",
            pudelkoB.DajWysokosc(),
            pudelkoB.DajSzerokosc(),
            pudelkoB.glebokosc,
            pudelkoB.Kolor);
        Console.WriteLine();


        Console.WriteLine("PudelkoA");
        Console.WriteLine("wysokość: {0}, szerokosc: {1}, głębokość: {2}, kolor: {3}, OBJETOŚĆ: {4}",
            pudelkoA.DajWysokosc(),
            pudelkoA.DajSzerokosc(),
            pudelkoA.glebokosc,
            pudelkoA.Kolor,
            pudelkoA.DajObjetosc());
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Liczba stworzonych pudełek w cyklu życia programu : {0}",
            Pudelko.dajIloscStworzonychPudelek());

        Console.ReadLine();

    }

    static void testujWektor()
    {
        double[] dane1 = { 1, 2, 3 };
        Wektor w1 = new Wektor(3, dane1);
        Console.Write("Wektor 1: ");
        w1.show();
        Console.WriteLine();

        double[] dane2 = { 4, 5, 6 };
        Wektor w2 = new Wektor(3, dane2);
        Console.Write("Wektor 2: ");
        w2.show();
        Console.WriteLine();

        Console.Write("Suma wektora 1: ");
        Console.WriteLine(w1.sum());

        Wektor w3 = w1.add(w2);
        Console.Write("Wektor 3 uzycie metody add: ");
        w3.show();
        Console.WriteLine();
    }
    static void testujProdukt()
    {

        Produkt produkt1 = new Produkt("serdelki", 5.50M, "sztuki", new DateTime(2022, 4, 18), 23, 23);
        Console.WriteLine("produkt1");
        produkt1.WypiszDane();
        Produkt produkt2 = produkt1.Clone();
        Console.WriteLine("produkt2");
        produkt2.WypiszDane();
        Produkt produkt3 = new Produkt();
        Console.WriteLine("produkt3");
        produkt3.WypiszDane();
        Console.ReadLine();

    }
    static void testujSprzedaz()
    {
        Sprzedaz sprzedaz1 = new Sprzedaz(new Produkt("serdelki", 5.50M, "sztuki", new DateTime(2022, 4, 18), 23, 23), 2, 12.50m);
        sprzedaz1.wypisz();
    }
    static void testujzamowienie()
    {

        Zamowienie zamowienie = new Zamowienie(DateTime.Now, "Eustachy Rajski");
        zamowienie.dodajPozycje(new Produkt("serdelki", 5.50M, "sztuki", new DateTime(2022, 4, 18), 23, 23), 2, 2.5M);
        zamowienie.dodajPozycje(new Sprzedaz(new Produkt("woda", 5.50M, "butelki", new DateTime(2022, 4, 18), 23, 23), 1, 3.0M));

        zamowienie.wypiszInformacje();
    }
    static void testujKonto()
    {

        Konto konto = new Konto("84382348238834", new Osoba("Alojzy", "Tateusz", "a.tateusz", 80, 1.8), DateTime.Today);

        for (int i = 0; i <= 500; i++)
        {
            konto.DodajTransakcje(new Transakcja(new DateTime(), "2222", 33.33M));
        }
        konto.DodajTransakcje(new Transakcja(new DateTime(), "custom", 44.44M));
        for (int i = 0; i <= 1000; i++)
        {
            konto.DodajTransakcje(new Transakcja(new DateTime(), "2222", -33.33M));
        }
        konto.DodajTransakcje(new Transakcja(new DateTime(), "custom", -44.44M));

        konto.WypiszInformacje();
        Console.WriteLine(konto.ToString());
    }
    static void testujTransakcje()
    {
        Konto konto = new Konto("84382348238834", new Osoba("Alojzy", "Tateusz", "a.tateusz", 80, 1.8), DateTime.Today);
        konto.WypiszInformacje();
        Console.WriteLine(konto.ToString());
    }
    static void testujKurs()
    {
        Osoba prowadzacy = new Osoba("adreusz", "tate", "andreusz.tate@hotmail.com", 48, 1.5);
        Grupa grupa1 = new Grupa("A", 30);
        Grupa grupa2 = new Grupa("B", 30);
        Grupa[] grupy = new Grupa[] { grupa1, grupa2 };
        Kurs kurs = new Kurs("jakies ", 30, prowadzacy, grupy);
        kurs.WypiszDane();
        Console.ReadKey();
    }
    static void testujRandom()
    {
        Console.WriteLine(RandomUtility.randomString(5));
        Console.WriteLine(RandomUtility.randomInt(0, 15));
        string[] arr = { "2", "d", "[", "h","g" };
        string[] res = RandomUtility.randomFromArray(3, arr, false);
        Console.WriteLine(string.Join("", res));
        Console.ReadKey();
    }
}
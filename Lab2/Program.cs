using Lab2;
internal class Program
{
    private static void Main(string[] args)
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
}
class Program
{
    static void Main(string[] args)
    {
        Opakowanie opakowanie = new Opakowanie(10, 5, 8, Material.Karton);

        Produkt produkt = new Produkt("Telewizor", 2000, "szt.", DateTime.Now, 23, 500);
        produkt.Opakowanie = opakowanie;

        produkt.WyswietlZeSzczegolami();

        Console.ReadLine();
    }
}
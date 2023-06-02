// See https://aka.ms/new-console-template for more information

using Lab5;



class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Hello, World!");


        Dane<string> daneString = new Dane<string>();
        daneString.Pole = "Przykładowy tekst";
        daneString.WypiszDane("Argument dla string");

        Dane<int> daneInt = new Dane<int>();
        daneInt.Pole = 42;
        daneInt.WypiszDane(123);

        Dane<double> daneDouble = new Dane<double>();
        daneDouble.Pole = 3.14;
        daneDouble.WypiszDane(2.71);

        Osoba[] osoby = new Osoba[]
        {
            new Osoba { Imie = "Jan", Nazwisko = "Kowalski", Wiek = 30 },
            new Osoba { Imie = "Anna", Nazwisko = "Nowak", Wiek = 25 },
            new Osoba { Imie = "Piotr", Nazwisko = "Wójcik", Wiek = 40 }
        };

        Zestawienie<Osoba> zestawienieOsob = new Zestawienie<Osoba>(osoby);
        zestawienieOsob.GenerujZestawienie();

        Console.WriteLine();

        Produkt[] produkty = new Produkt[]
        {
            new Produkt { Nazwa = "Telewizor", Cena = 1999.99m, StanMagazynowy = 10 },
            new Produkt { Nazwa = "Smartfon", Cena = 999.99m, StanMagazynowy = 5 },
            new Produkt { Nazwa = "Laptop", Cena = 2999.99m, StanMagazynowy = 3 }
        };

        Zestawienie<Produkt> zestawienieProduktow = new Zestawienie<Produkt>(produkty);
        zestawienieProduktow.GenerujZestawienie();

        TestujKolekcjeT();
        Console.ReadLine();
    }


    static void TestujKolekcjeT()
    {
        List<int> listaLiczb = new List<int>() { 5, 10, 15, 20, 25 };

        WyswietlListe(listaLiczb);

        listaLiczb.Insert(2, 12);

        WyswietlListe(listaLiczb);

        listaLiczb.RemoveAt(1);
        listaLiczb.Remove(15);
        WyswietlListe(listaLiczb);

        listaLiczb.Sort();

        WyswietlListe(listaLiczb);

        Console.ReadLine();
    }

    static void WyswietlListe(List<int> lista)
    {
        foreach (var element in lista)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}

class Osoba
{
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public int Wiek { get; set; }
}

class Produkt
{
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
    public int StanMagazynowy { get; set; }
}
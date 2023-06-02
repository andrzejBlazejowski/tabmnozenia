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


        Grupa grupa1 = new Grupa("Grupa 1", WypiszMetoda1);
        Grupa grupa2 = new Grupa("Grupa 2", WypiszMetoda2);
        Grupa grupa3 = new Grupa("Grupa 3", WypiszMetoda3);

        grupa1.Wypisz();
        grupa2.Wypisz2();
        grupa3.Wypisz3();


        Grupa grupa = new Grupa("Grupa 1", WypiszMetoda1);

        grupa.SprawdzanieObecnosci += (imie, nazwisko) =>
        {
            Console.WriteLine("Sprawdzanie obecności dla: " + imie + " " + nazwisko);
        };

        grupa.SprawdzObecnosc("Jan", "Kowalski");
        grupa.SprawdzObecnosc("Anna", "Nowak");


        Console.ReadLine();
    }

    public static void WypiszMetoda1()
    {
        Console.WriteLine("Wywołano WypiszMetoda1()");
    }

    public static void WypiszMetoda2()
    {
        Console.WriteLine("Wywołano WypiszMetoda2()");
    }

    public static void WypiszMetoda3()
    {
        Console.WriteLine("Wywołano WypiszMetoda3()");
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

        MojaData data1 = new MojaData(new DateTime(1990, 5, 20));
        int lata = data1;
        Console.WriteLine("Lata: " + lata);

        MojaData data2 = new MojaData(new DateTime(1995, 12, 31));
        float lataFloat = (float)data2; 
        Console.WriteLine("Lata (z ułamkiem): " + lataFloat);
        
        
        StringIntDelegate delegateObj = null;

        delegateObj += DelegationExample.AppendNumber;
        delegateObj += DelegationExample.RepeatString;
        delegateObj += DelegationExample.GetSubstring;

        string result = delegateObj.Invoke("Hello", 3);

        Console.WriteLine(result);


        Console.ReadLine();
    }
        public static void testCalculationDelegate()
    {
        Console.WriteLine("Podaj trzy liczby:");

        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        double result = double.Parse(Console.ReadLine());

        CalculationDelegate calculationDelegate = null;

        calculationDelegate += Calculator.Add;
        calculationDelegate += Calculator.Subtract;
        calculationDelegate += Calculator.Multiply;
        calculationDelegate += Calculator.Divide;

        double closestResult = double.MaxValue;
        string closestOperation = string.Empty;

        foreach (CalculationDelegate calc in calculationDelegate.GetInvocationList())
        {
            double calculatedResult = calc.Invoke(num1, num2);
            double difference = Math.Abs(calculatedResult - result);

            if (difference < Math.Abs(closestResult - result))
            {
                closestResult = calculatedResult;
                closestOperation = calc.Method.Name;
            }
        }

        Console.WriteLine($"Najbliższe działanie to: {num1} {closestOperation} {num2} = {closestResult}");
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
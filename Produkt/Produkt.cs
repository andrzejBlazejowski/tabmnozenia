
using System.Reflection;

public enum Material
{
    Karton,
    Szklo,
    Plastik,
    Metal,
    Papier
}

public struct Opakowanie
{
    public double Dlugosc { get; set; }
    public double Szerokosc { get; set; }
    public double Wysokosc { get; set; }
    public Material Material { get; set; }

    public Opakowanie(double dlugosc, double szerokosc, double wysokosc, Material material)
    {
        Dlugosc = dlugosc;
        Szerokosc = szerokosc;
        Wysokosc = wysokosc;
        Material = material;
    }

    public double Objetosc
    {
        get { return Dlugosc * Szerokosc * Wysokosc; }
    }

    public override string ToString()
    {
        return $"Opakowanie: {Material}, Wymiary: {Dlugosc} x {Szerokosc} x {Wysokosc}";
    }
}

public class Produkt
{
    public string Nazwa { get; set; }
    public decimal CenaZakupu { get; set; }
    public string JednostkaMiary { get; set; }
    protected DateTime DataZakupu;
    private decimal StawkaVAT;
    private decimal Marza;
    public Opakowanie Opakowanie { get; set; }

    public Produkt(string nazwa, decimal cenaZakupu, string jednostkaMiary, DateTime dataZakupu, decimal stawkaVAT, decimal marza)
    {
        Nazwa = nazwa;
        CenaZakupu = cenaZakupu;
        JednostkaMiary = jednostkaMiary;
        DataZakupu = dataZakupu;
        StawkaVAT = stawkaVAT;
        Marza = marza;
    }

    public Produkt()
    {
        Console.WriteLine("Wpisz nazwę produktu:");
        Nazwa = Console.ReadLine();

        Console.WriteLine("Wpisz cenę zakupu produktu:");
        decimal cenaZakupu;
        while (!decimal.TryParse(Console.ReadLine(), out cenaZakupu))
        {
            Console.WriteLine("Błędna wartość, wpisz cenę zakupu:");
        }
        CenaZakupu = cenaZakupu;

        Console.WriteLine("Wpisz jednostkę miary produktu:");
        JednostkaMiary = Console.ReadLine();

        Console.WriteLine("Wpisz datę zakupu w formacie dd/MM/yyyy:");
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DataZakupu))
        {
            Console.WriteLine("Błędna wartość, wpisz datę zakupu w formacie dd/MM/yyyy:");
        }

        Console.WriteLine("Wpisz stawkę VAT produktu:");
        while (!decimal.TryParse(Console.ReadLine(), out StawkaVAT))
        {
            Console.WriteLine("Błędna wartość, wpisz stawkę VAT:");
        }

        Console.WriteLine("Wpisz marżę (zysk) produktu:");
        while (!decimal.TryParse(Console.ReadLine(), out Marza))
        {
            Console.WriteLine("Błędna wartość, wpisz marżę :");
        }
    }

    public virtual void WypiszDane()
    {
        Console.WriteLine("Nazwa produktu: {0}", Nazwa);
        Console.WriteLine("Cena zakupu: {0} zł", CenaZakupu);
        Console.WriteLine("Jednostka miary: {0}", JednostkaMiary);
        Console.WriteLine("Data zakupu: {0}", DataZakupu.ToString("dd/MM/yyyy"));
        Console.WriteLine("Stawka VAT: {0}%", StawkaVAT);
        Console.WriteLine("Marża: {0} zł", Marza);
    }

    public decimal CenaDetaliczna()
    {
        decimal cenaNetto = CenaZakupu + CenaZakupu * StawkaVAT / 100;
        decimal cenaDetaliczna = cenaNetto + Marza;
        return cenaDetaliczna;
    }

    public void WyswietlZeSzczegolami()
    {
        WypiszDane();

        if (Opakowanie.Dlugosc != 0)
        {
            Console.WriteLine("Opakowanie: {0}", Opakowanie.ToString());
        }
        else
        {
            Console.WriteLine("Opakowanie: brak");
        }
    }

    public object this[string fieldName]
    {
        get
        {
            var field = this.GetType().GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                return field.GetValue(this);
            }
            else
            {
                var property = this.GetType().GetProperty(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (property != null)
                {
                    return property.GetValue(this);
                }
            }
            throw new ArgumentException($"Nie znaleziono pola o nazwie {fieldName} w klasie {this.GetType().Name}");
        }
        set
        {
            var field = this.GetType().GetField(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (field != null)
            {
                field.SetValue(this, value);
            }
            else
            {
                var property = this.GetType().GetProperty(fieldName, BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (property != null)
                {
                    property.SetValue(this, value);
                }
            }
            throw new ArgumentException($"Nie znaleziono pola o nazwie {fieldName} w klasie {this.GetType().Name}");
        }
    }
    public Produkt Clone()
    {
        return new Produkt(this.Nazwa, this.CenaZakupu, this.JednostkaMiary, this.DataZakupu, this.StawkaVAT, this.Marza);
    }
}
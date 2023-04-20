
using System.Reflection;

public class Produkt
{
    public string nazwa { get; set; }
    public decimal cenaZakupu { get; set; }
    public string jednostkaMiary { get; set; }
    private DateTime dataZakupu;
    private decimal stawkaVAT;
    private decimal marza;

    public Produkt(string nazwa, decimal cenaZakupu, string jednostkaMiary, DateTime dataZakupu, decimal stawkaVAT, decimal marza)
    {
        this.nazwa = nazwa;
        this.cenaZakupu = cenaZakupu;
        this.jednostkaMiary = jednostkaMiary;
        this.dataZakupu = dataZakupu;
        this.stawkaVAT = stawkaVAT;
        this.marza = marza;
    }

    public Produkt()
    {
        Console.WriteLine("Wpisz nazwę produktu:");
        this.nazwa = Console.ReadLine();

        Console.WriteLine("wpisz cenę zakupu produktu:");
        decimal cenaZakupu ;
        while (!decimal.TryParse(Console.ReadLine(), out cenaZakupu))
        {
            Console.WriteLine("Błędna wartość, wpisz cenę zakupu:");
        }
        this.cenaZakupu = cenaZakupu;

        Console.WriteLine("wpisz jednostkę miary produktu:");
        this.jednostkaMiary = Console.ReadLine();

        Console.WriteLine("wpisz datę zakupu w formacie dd/MM/yyyy:");
        while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out this.dataZakupu))
        {
            Console.WriteLine("Błędna wartość, wpisz datę zakupu w formacie dd/MM/yyyy:");
        }

        Console.WriteLine("wpisz stawkę VAT produktu:");
        while (!decimal.TryParse(Console.ReadLine(), out this.stawkaVAT))
        {
            Console.WriteLine("Błędna wartość, wpisz stawkę VAT:");
        }

        Console.WriteLine("wpisz marżę (zysk) produktu:");
        while (!decimal.TryParse(Console.ReadLine(), out this.marza))
        {
            Console.WriteLine("Błędna wartość, wpisz marżę :");
        }
    }

    public void WypiszDane()
    {
        Console.WriteLine("Nazwa produktu: {0}", this.nazwa);
        Console.WriteLine("Cena zakupu: {0} zł", this.cenaZakupu);
        Console.WriteLine("Jednostka miary: {0}", this.jednostkaMiary);
        Console.WriteLine("Data zakupu: {0}", this.dataZakupu.ToString());
        Console.WriteLine("Stawka VAT: {0}%", this.stawkaVAT);
        Console.WriteLine("Marża: {0} zł", this.marza);
    }
    public decimal CenaDetaliczna()
    {
        decimal cenaNetto = cenaZakupu + cenaZakupu * stawkaVAT / 100;
        decimal cenaDetaliczna = cenaNetto + marza;
        return cenaDetaliczna;
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
        return new Produkt(this.nazwa, this.cenaZakupu, this.jednostkaMiary, this.dataZakupu, this.stawkaVAT, this.marza);
    }
}
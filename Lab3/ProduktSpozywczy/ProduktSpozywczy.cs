using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.ProduktSpozywczy
{
    public class ProduktSpozywczy : Produkt
    {
        public int terminPrzydatnosci { get; set; }
        public float waga { get; set; }

        public ProduktSpozywczy(string nazwa, decimal cenaZakupu, string jednostkaMiary, DateTime dataZakupu, decimal stawkaVAT, decimal marza, int terminPrzydatnosci, float waga)
            : base(nazwa, cenaZakupu, jednostkaMiary, dataZakupu, stawkaVAT, marza)
        {
            this.terminPrzydatnosci = terminPrzydatnosci;
            this.waga = waga;
        }

        public bool doSpozycia()
        {
            return doSpozycia(DateTime.Now);
        }

        public bool doSpozycia(DateTime data)
        {
            TimeSpan czas = data.Date - this.dataZakupu.Date;
            return czas.Days < this.terminPrzydatnosci;
        }

        public override void WypiszDane()
        {
            base.WypiszDane();
            Console.WriteLine("Termin przydatności do spożycia: {0} dni", this.terminPrzydatnosci);
            Console.WriteLine("Waga: {0} kg", this.waga);
        }
    }
}

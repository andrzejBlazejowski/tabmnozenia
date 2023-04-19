using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.zamowienie
{    public class Transakcja
    {
        private DateTime data;
        private string tytul;
        public decimal kwota { get; set; }

        public Transakcja(DateTime data, string tytul, decimal kwota)
        {
            this.data = data;
            this.tytul = tytul;
            this.kwota = kwota;
        }

        public void WypiszInformacje()
        {
            Console.WriteLine("Data: {0}, Tytuł: {1}, Kwota: {2:C}", data.ToString(), tytul, kwota);
        }
    }
}

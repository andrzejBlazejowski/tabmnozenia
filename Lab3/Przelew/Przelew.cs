using Lab2.zamowienie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Przelew
{
    public class Przelew : Transakcja
    {
        public Konto konto;

        public Przelew(decimal kwota, DateTime data, string tytul, Konto konto) : base(data, tytul, kwota)
        {
            this.konto = konto;
        }

        public override void WypiszInformacje()
        {
            base.WypiszInformacje();
            Console.WriteLine("Konto docelowe: {0}", konto.numerKonta);
            Console.WriteLine("Konto źródłowe: {0}", konto);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.zamowienie
{
    public class Konto
    {
        private string nazwaWlasciciela;
        private string numerKonta;
        private DateTime dataUtworzenia;

        public Konto(string numerKonta, string nazwaWlasciciela, DateTime dataUtworzenia)
        {
            this.numerKonta = numerKonta;
            this.nazwaWlasciciela = nazwaWlasciciela;
            this.dataUtworzenia = dataUtworzenia;
        }

        public void WypiszInformacje()
        {
            Console.WriteLine("Numer konta: {0}", numerKonta);
            Console.WriteLine("Nazwa właściciela: {0}", nazwaWlasciciela);
            Console.WriteLine("Data utworzenia: {0}", dataUtworzenia.ToString());
        }

        public override string ToString()
        {
            return string.Format("Numer konta: {0}, nazwa właściciela: {1}, data utworzenia: {2}",
                numerKonta, nazwaWlasciciela, dataUtworzenia.ToString());
        }
    }
}

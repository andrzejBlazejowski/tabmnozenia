using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.zamowienie
{
    public class Konto
    {
        private string nazwaWlasciciela;
        private string numerKonta;
        private DateTime dataUtworzenia;
        private Transakcja[][] transakcje = new Transakcja[2][];
        private int liczbaObciazen = 0;
        private int liczbaUznan = 0;

        public Konto(string numerKonta, string nazwaWlasciciela, DateTime dataUtworzenia)
        {
            this.numerKonta = numerKonta;
            this.nazwaWlasciciela = nazwaWlasciciela;
            this.dataUtworzenia = dataUtworzenia;
            transakcje[1] = new Transakcja[500];
            transakcje[0] = new Transakcja[1000];
        }


        public void DodajTransakcje(Transakcja transakcja)
        {
            if(transakcja.kwota > 0)
            {
                dodajUznanie(transakcja);
            }
            else if (transakcja.kwota < 0)
            {
                dodajObciazenie(transakcja);
            }
            else
            {
                Console.WriteLine("nieprawidłowa Kwota w transakcji, podczas dodawania do konta");
            }
        }

        private void dodajObciazenie(Transakcja transakcja)
        {
            transakcje[1][liczbaObciazen % transakcje[1].Length] = transakcja;

            liczbaObciazen++;
        }

        private void dodajUznanie(Transakcja transakcja)
        {
            transakcje[0][liczbaObciazen % transakcje[0].Length] = transakcja;

            liczbaObciazen++;
        }

        public void WypiszInformacje()
        {
            Console.WriteLine("Numer konta: {0}", numerKonta);
            Console.WriteLine("Nazwa właściciela: {0}", nazwaWlasciciela);
            Console.WriteLine("Data utworzenia: {0}", dataUtworzenia.ToString());

            Console.WriteLine("obciążenia : ");
            foreach (Transakcja t in transakcje[1]) 
            {
                if(t != null) t.WypiszInformacje();
            }
            Console.WriteLine("uznania : ");
            foreach (Transakcja t in transakcje[0])
            {
                if (t != null) t.WypiszInformacje();
            }
        }

        public override string ToString()
        {
            return string.Format("Numer konta: {0}, nazwa właściciela: {1}, data utworzenia: {2}",
                numerKonta, nazwaWlasciciela, dataUtworzenia.ToString());
        }
    }
}

using Lab2.kurs;
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
        private Osoba wlasciciel;
        private string numerKonta;
        private DateTime dataUtworzenia;
        private Transakcja[][] transakcje = new Transakcja[2][];
        private int liczbaObciazen = 0;
        private int liczbaUznan = 0;

        public Konto(string numerKonta, Osoba wlasciciel, DateTime dataUtworzenia)
        {
            this.numerKonta = numerKonta;
            this.wlasciciel = wlasciciel;
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
        public decimal Saldo
        {
            get
            {
                decimal saldo = 0;
                foreach (Transakcja t in transakcje[0])
                {
                    if (t != null) saldo += t.kwota;
                }
                foreach (Transakcja t in transakcje[1])
                {
                    if (t != null) saldo += t.kwota;
                }
                return saldo;
            }
        }
        public void uznajKonto(Transakcja t)
        {
            if (t.kwota > 0)
            {
                transakcje[0][liczbaUznan % transakcje[0].Length] = t;
                liczbaUznan++;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa kwota transakcji, podczas uznawania konta");
            }
        }

        public void obciazKonto(Transakcja t)
        {
            if (t.kwota < 0)
            {
                transakcje[1][liczbaObciazen % transakcje[1].Length] = t;
                liczbaObciazen++;
            }
            else
            {
                Console.WriteLine("Nieprawidłowa kwota transakcji, podczas obciążania konta");
            }
        }
        public Transakcja[] this[string rodzajTransakcji]
        {
            get
            {
                if (rodzajTransakcji == "uznania")
                {
                    return transakcje[0];
                }
                else if (rodzajTransakcji == "obciazenia")
                {
                    return transakcje[1];
                }
                else
                {
                    throw new ArgumentException("Nieprawidłowy rodzaj transakcji");
                }
            }
        }
        public void WypiszInformacje()
        {
            Console.WriteLine("Numer konta: {0}", numerKonta);
            Console.WriteLine("Nazwa właściciela: {0}", wlasciciel.Imie);
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
                numerKonta, wlasciciel.Imie, dataUtworzenia.ToString());
        }
    }
}

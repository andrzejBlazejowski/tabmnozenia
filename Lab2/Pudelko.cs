using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Pudelko
    {
        private double szerokosc;
        private double wysokosc;
        public double glebokosc { get; set; }
        private string kolor;
        public string Kolor
        {
            get
            {
                return this.kolor;
            }
            set
            {
                this.kolor = value;
            }
        }
        private static int iloscStworzonychPudelek = 0;


        public void UstawSzerokosc(double szerokosc1)
        {
            this.szerokosc = szerokosc1;
        }

        public double DajSzerokosc()
        {
            return this.szerokosc;
        }
        public void UstawWysokosc(double wysokosc1)
        {
            this.wysokosc = wysokosc1;
        }

        public double DajWysokosc()
        {
            return this.wysokosc;
        }

        public double DajObjetosc()
        {
            return this.wysokosc * this.szerokosc * this.glebokosc;
        }

        public static int dajIloscStworzonychPudelek()
        {
            return iloscStworzonychPudelek;
        }

        public Pudelko(double szerokosc1, double wysokosc1, double glebokosc1, string kolor1)
        {
            this.szerokosc = szerokosc1;
            this.wysokosc = wysokosc1;
            this.glebokosc = glebokosc1;
            this.Kolor = kolor1;

            iloscStworzonychPudelek++;
        }
        public Pudelko()
        {
            this.szerokosc = 0;
            this.wysokosc = 0;
            this.glebokosc = 0;
            this.Kolor = "";

            iloscStworzonychPudelek++;
        }
        public Pudelko(Pudelko wzorPudelka)
        {
            this.szerokosc = wzorPudelka.szerokosc;
            this.wysokosc = wzorPudelka.wysokosc;
            this.glebokosc = wzorPudelka.glebokosc;
            this.Kolor = wzorPudelka.kolor;

            iloscStworzonychPudelek++;
        }
    }
}

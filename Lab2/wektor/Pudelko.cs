using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.wektor
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
                return kolor;
            }
            set
            {
                kolor = value;
            }
        }
        private static int iloscStworzonychPudelek = 0;


        public void UstawSzerokosc(double szerokosc1)
        {
            szerokosc = szerokosc1;
        }

        public double DajSzerokosc()
        {
            return szerokosc;
        }
        public void UstawWysokosc(double wysokosc1)
        {
            wysokosc = wysokosc1;
        }

        public double DajWysokosc()
        {
            return wysokosc;
        }

        public double DajObjetosc()
        {
            return wysokosc * szerokosc * glebokosc;
        }

        public static int dajIloscStworzonychPudelek()
        {
            return iloscStworzonychPudelek;
        }

        public Pudelko(double szerokosc1, double wysokosc1, double glebokosc1, string kolor1)
        {
            szerokosc = szerokosc1;
            wysokosc = wysokosc1;
            glebokosc = glebokosc1;
            Kolor = kolor1;

            iloscStworzonychPudelek++;
        }
        public Pudelko()
        {
            szerokosc = 0;
            wysokosc = 0;
            glebokosc = 0;
            Kolor = "";

            iloscStworzonychPudelek++;
        }
        public Pudelko(Pudelko wzorPudelka)
        {
            szerokosc = wzorPudelka.szerokosc;
            wysokosc = wzorPudelka.wysokosc;
            glebokosc = wzorPudelka.glebokosc;
            Kolor = wzorPudelka.kolor;

            iloscStworzonychPudelek++;
        }
    }
}

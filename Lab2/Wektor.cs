using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{

    class Wektor
    {
        private int n; // liczba współrzędnych
        private double[] wspolrzedne; // tablica współrzędnych

        public Wektor(int n, double[] dane)
        {
            this.n = n;
            this.wspolrzedne = new double[n];
            for (int i = 0; i < n; i++)
            {
                this.wspolrzedne[i] = dane[i];
            }
        }

        public void show()
        {
            Console.Write("(");
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(wspolrzedne[i] + ", ");
            }
            Console.Write(wspolrzedne[n - 1] + ")");
        }

        public double sum()
        {
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += wspolrzedne[i];
            }
            return suma;
        }

        public Wektor add(Wektor w)
        {
            if (this.n != w.n)
            {
                throw new ArgumentException("Wektory muszą mieć taką samą liczbę współrzędnych!");
            }
            double[] noweWspolrzedne = new double[n];
            for (int i = 0; i < n; i++)
            {
                noweWspolrzedne[i] = this.wspolrzedne[i] + w.wspolrzedne[i];
            }
            return new Wektor(n, noweWspolrzedne);
        }
    }
}

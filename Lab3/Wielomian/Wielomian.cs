using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Lab2;
using Lab2.wektor;

namespace Lab3.Wielomian
{


    public class Wielomian : Wektor
    {
        public Wielomian(double[] dane) : base(dane) { }

        public double dajWartosc(double x)
        {
            double wynik = 0;
            for (int i = 0; i < n; i++)
            {
                wynik += Wspolrzedne[i] * Math.Pow(x, i);
            }
            return wynik;
        }

        public override void show()
        {
            base.show();
            Console.Write("Wielomian: ");
            for (int i = n - 1; i >= 0; i--)
            {
                if (Wspolrzedne[i] == 0) continue;

                if (Wspolrzedne[i] > 0 && i != n - 1) Console.Write("+");

                if (Wspolrzedne[i] != 1 || i == 0) Console.Write(Wspolrzedne[i]);

                if (i > 1) Console.Write("x^" + i);
                else if (i == 1) Console.Write("x");

            }
            Console.WriteLine();
        }
    }
}

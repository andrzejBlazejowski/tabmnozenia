using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.wektor
{

    class Wektor
    {
        private int n;
        private double[] wspolrzedne;

        public Wektor(int n, double[] dane)
        {
            this.n = n;
            wspolrzedne = new double[n];
            for (int i = 0; i < n; i++)
            {
                wspolrzedne[i] = dane[i];
            }
        }

        public void show()
        {
            Console.Write("wspolrzedne wektora to: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(wspolrzedne[i] + (i != n - 1 ? ", " : ""));
            }
            Console.WriteLine();
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

        public Wektor add(Wektor scalar)
        {
            if (n != scalar.n)
            {
                Console.WriteLine("Nieprawidłowa długość wektora.");
                return null;
            }
            double[] noweWspolrzedne = new double[n];
            for (int i = 0; i < n; i++)
            {
                noweWspolrzedne[i] = wspolrzedne[i] + scalar.wspolrzedne[i];
            }
            return new Wektor(n, noweWspolrzedne);
        }
    }
}

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
        private static char znakWypisywania;
        private static Random random = new Random();
        public Wektor(int n, double a, double b)
        {
            this.n = n;
            this.wspolrzedne = new double[n];
            for (int i = 0; i < n; i++)
            {
                wspolrzedne[i] = random.NextDouble() * (b - a) + a;
            }
        }
        static Wektor()
        {
            Console.Write("Podaj znak wypisywania wektorów: ");
            znakWypisywania = Console.ReadKey().KeyChar;
            Console.WriteLine();
        }
        public Wektor(int n, double[] dane)
        {
            this.n = n;
            wspolrzedne = new double[n];
            for (int i = 0; i < n; i++)
            {
                wspolrzedne[i] = dane[i];
            }
        }
        public Wektor(double[] dane)
        {
            this.n = dane.Length;
            this.wspolrzedne = dane;
        }
        public static Wektor zbudujWektor()
        {
            Console.Write("Wpisz ilość współrzędnych wektora: ");
            int n = int.Parse(Console.ReadLine());

            double[] dane = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Wpisz wartość współrzędnej nr {0}: ", i + 1);
                dane[i] = double.Parse(Console.ReadLine());
            }

            return new Wektor(dane);
        }

        public void show()
        {
            Console.Write("wspolrzedne wektora to: "+ znakWypisywania);
            for (int i = 0; i < n; i++)
            {
                Console.Write(wspolrzedne[i] + (i != n - 1 ? ", " : ""));
            }
            Console.Write(znakWypisywania);
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

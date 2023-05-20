using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wektor
{

    public class Wektor
    {
        public int n { get; set; }
        public double[] Wspolrzedne { get; set; }
        private static char znakWypisywania;
        private static Random random = new Random();
        public Wektor(int n, double a, double b)
        {
            this.n = n;
            this.Wspolrzedne = new double[n];
            for (int i = 0; i < n; i++)
            {
                Wspolrzedne[i] = random.NextDouble() * (b - a) + a;
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
            Wspolrzedne = new double[n];
            for (int i = 0; i < n; i++)
            {
                Wspolrzedne[i] = dane[i];
            }
        }
        public Wektor(double[] dane)
        {
            this.n = dane.Length;
            this.Wspolrzedne = dane;
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

        public virtual void show()
        {
            Console.Write("wspolrzedne wektora to: "+ znakWypisywania);
            for (int i = 0; i < n; i++)
            {
                Console.Write(Wspolrzedne[i] + (i != n - 1 ? ", " : ""));
            }
            Console.Write(znakWypisywania);
            Console.WriteLine();
        }

        public double sum()
        {
            double suma = 0;
            for (int i = 0; i < n; i++)
            {
                suma += Wspolrzedne[i];
            }
            return suma;
        }
        public double this[int i]
        {
            get { return Wspolrzedne[i]; }
            set { Wspolrzedne[i] = value; }
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
                noweWspolrzedne[i] = Wspolrzedne[i] + scalar.Wspolrzedne[i];
            }
            return new Wektor(n, noweWspolrzedne);
        }

        public static Wektor operator +(Wektor vector1, Wektor vector2)
        {
            if (vector1.n != vector2.n)
            {
                Console.WriteLine("Nieprawidłowa długość wektorów.");
                return null;
            }
            double[] newCoordinates = new double[vector1.n];
            for (int i = 0; i < vector1.n; i++)
            {
                newCoordinates[i] = vector1.Wspolrzedne[i] + vector2.Wspolrzedne[i];
            }
            return new Wektor(vector1.n, newCoordinates);
        }

        public static Wektor operator *(Wektor vector, double scalar)
        {
            double[] newCoordinates = new double[vector.n];
            for (int i = 0; i < vector.n; i++)
            {
                newCoordinates[i] = vector.Wspolrzedne[i] * scalar;
            }
            return new Wektor(vector.n, newCoordinates);
        }

        public static double operator *(Wektor vector1, Wektor vector2)
        {
            if (vector1.n != vector2.n)
            {
                Console.WriteLine("Nieprawidłowa długość wektorów.");
                return 0;
            }
            double result = 0;
            for (int i = 0; i < vector1.n; i++)
            {
                result += vector1.Wspolrzedne[i] * vector2.Wspolrzedne[i];
            }
            return result;
        }

    }
}

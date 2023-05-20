using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania4
{
    using System;

    struct LWymierna
    {
        private int licznik;
        private int mianownik;

        public LWymierna(int l, int m)
        {
            if (m == 0)
                throw new ArgumentException("Mianownik nie może być zerem.");

            licznik = l;
            mianownik = m;

            Uporzadkuj();
        }

        public LWymierna(int l)
        {
            licznik = l;
            mianownik = 1;
        }

        public LWymierna()
        {
            licznik = 0;
            mianownik = 1;
        }

        public void wczytajUlamek()
        {
            Console.WriteLine("Podaj licznik:");
            licznik = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj mianownik:");
            mianownik = Convert.ToInt32(Console.ReadLine());

            if (mianownik == 0)
                throw new ArgumentException("Mianownik nie może być zerem.");

            Uporzadkuj();
        }

        public void wypiszUlamek()
        {
            Console.WriteLine("{0}/{1}", licznik, mianownik);
        }

        public LWymierna dodaj(LWymierna other)
        {
            int l = licznik * other.mianownik + other.licznik * mianownik;
            int m = mianownik * other.mianownik;
            return new LWymierna(l, m);
        }

        public LWymierna odjac(LWymierna other)
        {
            int l = licznik * other.mianownik - other.licznik * mianownik;
            int m = mianownik * other.mianownik;
            return new LWymierna(l, m);
        }

        public LWymierna razy(LWymierna other)
        {
            int l = licznik * other.licznik;
            int m = mianownik * other.mianownik;
            return new LWymierna(l, m);
        }

        public LWymierna dziel(LWymierna other)
        {
            int l = licznik * other.mianownik;
            int m = mianownik * other.licznik;
            return new LWymierna(l, m);
        }

        public bool mniejsze(LWymierna other)
        {
            double val1 = (double)licznik / mianownik;
            double val2 = (double)other.licznik / other.mianownik;
            return val1 < val2;
        }
        public bool wieksze(LWymierna other)
        {
            double val1 = (double)licznik / mianownik;
            double val2 = (double)other.licznik / other.mianownik;
            return val1 > val2;
        }

        public LWymierna minus()
        {
            return new LWymierna(-licznik, mianownik); }
        private void Uporzadkuj()
        {
            if (mianownik < 0)
            {
                licznik = -licznik;
                mianownik = -mianownik;
            }
        }
    }
}

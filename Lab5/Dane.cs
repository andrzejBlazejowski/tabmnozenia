using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Dane<T>
    {
        private T dane;

        public T Pole
        {
            get { return dane; }
            set { dane = value; }
        }

        public void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public void WypiszDane(T argument)
        {
            Console.WriteLine("Aktualny typ: {0}", typeof(T).Name);
            Console.WriteLine("Wartość pola: {0}", Pole);
            Console.WriteLine("Wartość właściwości: {0}", Pole);
            Console.WriteLine("Argument metody: {0}", argument);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Figury
{
    public class Trojkat : Figura
    {
        private double a, b, c;

        public Trojkat(double a, double b, double c, string kolorObramowania, string kolorKrawedzi) : base("Trójkąt", kolorObramowania, kolorKrawedzi)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Pole()
        {
            double p = (a + b + c) / 2;
            double pole = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Pole trójkąta wynosi: {0}", pole);
        }

        public override void Obwod()
        {
            double obwod = a + b + c;
            Console.WriteLine("Obwód trójkąta wynosi: {0}", obwod);
        }
    }
}

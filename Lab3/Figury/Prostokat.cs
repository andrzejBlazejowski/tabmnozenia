tusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Figury
{
    public class Prostokat : Figura
    {
        private double a, b;

        public Prostokat(double a, double b, string kolorObramowania, string kolorKrawedzi) : base("Prostokąt", kolorObramowania, kolorKrawedzi)
        {
            this.a = a;
            this.b = b;
        }

        public override void Pole()
        {
            double pole = a * b;
            Console.WriteLine("Pole prostokąta wynosi: {0}", pole);
        }

        public override void Obwod()
        {
            double obwod = 2 * a + 2 * b;
            Console.WriteLine("Obwód prostokąta wynosi: {0}", obwod);
        }
    }
}

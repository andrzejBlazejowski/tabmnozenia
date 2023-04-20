using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Figury
{
    public abstract class AbstractFigura
    {
        protected string typFigury;
        protected string kolorObramowania;
        protected string kolorKrawedzi;

        public AbstractFigura(string typFigury, string kolorObramowania, string kolorKrawedzi)
        {
            this.typFigury = typFigury;
            this.kolorObramowania = kolorObramowania;
            this.kolorKrawedzi = kolorKrawedzi;
        }

        public void Naglowek()
        {
            Console.WriteLine($"Typ figury: {typFigury}, kolor obramowania: {kolorObramowania}, kolor krawedzi: {kolorKrawedzi}");
        }

        public abstract double Pole();
        public abstract double Obwod();
    }
}

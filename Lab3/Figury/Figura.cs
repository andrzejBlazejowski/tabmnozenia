using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Figury
{

    public class Figura
    {
        public string typFigury;
        public string kolorObramowania;
        public string kolorKrawedzi;

        public Figura(string typFigury, string kolorObramowania, string kolorKrawedzi)
        {
            this.typFigury = typFigury;
            this.kolorObramowania = kolorObramowania;
            this.kolorKrawedzi = kolorKrawedzi;
        }

        public void Naglowek()
        {
            Console.WriteLine("Typ figury: {0}, kolor obramowania: {1}, kolor krawędzi: {2}", typFigury, kolorObramowania, kolorKrawedzi);
        }

        public virtual void Pole()
        {
            Console.WriteLine("Pole figury");
        }

        public virtual void Obwod()
        {
            Console.WriteLine("Obwód figury");
        }
    }

}

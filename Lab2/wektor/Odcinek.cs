using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.wektor
{
    public class Odcinek
    {
        public Punkt a { get; set; }
        public Punkt b { get; set; }

        public Odcinek()
        {
            a = new Punkt();
            b = new Punkt();
        }

        public Odcinek(int x1, int y1, int x2, int y2)
        {
            a = new Punkt(x1, y1);
            b = new Punkt(x2, y2);
        }

        public void Wypisz()
        {
            Console.WriteLine("punkt a : ");
            a.Wypisz();
            Console.WriteLine("punkt b : ");
            b.Wypisz();
        }

        public double Dlugosc()
        {
            return Math.Sqrt(Math.Pow(b.x - a.x, 2) + Math.Pow(b.y - a.y, 2));
        }

        public void ZmianaPoczatku(int x, int y)
        {
            a.y = y;
            a.x = x;
        }

        public void ZmianaKonca(int x, int y)
        {
            b.y = y;
            b.x = x;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Punkt
    {
        public int x { get; set; }
        public int y { get; set; }

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public Punkt()
        {
            this.x = 0;
            this.y = 0;
        }
        public void Wypisz() {
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }
}

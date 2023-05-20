using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadania4
{

    public struct LiczbaZespolona
    {
        public double Re { get; set; } 
        public double Im { get; set; } 

        public LiczbaZespolona(double re, double im)
        {
            Re = re;
            Im = im;
        }

        public static LiczbaZespolona operator +(LiczbaZespolona z1, LiczbaZespolona z2)
        {
            double re = z1.Re + z2.Re;
            double im = z1.Im + z2.Im;
            return new LiczbaZespolona(re, im);
        }

        public static LiczbaZespolona operator -(LiczbaZespolona z1, LiczbaZespolona z2)
        {
            double re = z1.Re - z2.Re;
            double im = z1.Im - z2.Im;
            return new LiczbaZespolona(re, im);
        }
        public static LiczbaZespolona operator *(LiczbaZespolona z1, LiczbaZespolona z2)
        {
            double re = z1.Re * z2.Re - z1.Im * z2.Im;
            double im = z1.Re * z2.Im + z1.Im * z2.Re;
            return new LiczbaZespolona(re, im);
        }

        public static LiczbaZespolona operator /(LiczbaZespolona z1, LiczbaZespolona z2)
        {
            double denominator = z2.Re * z2.Re + z2.Im * z2.Im;
            double re = (z1.Re * z2.Re + z1.Im * z2.Im) / denominator;
            double im = (z1.Im * z2.Re - z1.Re * z2.Im) / denominator;
            return new LiczbaZespolona(re, im);
        }

        public static LiczbaZespolona operator -(LiczbaZespolona z)
        {
            double re = -z.Re;
            double im = -z.Im;
            return new LiczbaZespolona(re, im);
        }
    }
}

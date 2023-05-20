// See https://aka.ms/new-console-template for more information

using Wektor;

namespace Wektor
{
    class Program
    {
        static void Main()
        {
            Wektor vector1 = new Wektor(3, new double[] { 1, 2, 3 });
            Wektor vector2 = new Wektor(3, new double[] { 4, 5, 6 });

            Wektor sum = vector1 + vector2;
            Wektor scaled = vector1 * 2;
            double produkt = vector1 * vector2;

            sum.show();
            scaled.show();
            Console.WriteLine("produkt: {0}", produkt);
        }
    }
}
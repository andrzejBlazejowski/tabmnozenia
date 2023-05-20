// See https://aka.ms/new-console-template for more information

using zadania4;

namespace tabmnozenia
{
    class Program
    {
        static void Main()
        {
            testZespolone();
        }

        public static void testZespolone()
        {

            LiczbaZespolona z1 = new LiczbaZespolona(3, 2);
            LiczbaZespolona z2 = new LiczbaZespolona(1, 4);

            LiczbaZespolona z3 = z1 + z2;
            Console.WriteLine("z3 = {0} + {1}i", z3.Re, z3.Im);
        }
    }
}


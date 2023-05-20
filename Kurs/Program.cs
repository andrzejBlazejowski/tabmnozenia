// See https://aka.ms/new-console-template for more information

using Kurs;

namespace Kurs
{
    class Program
    {
        static void Main()
        {
            Grupa grupa1 = new Grupa("Grupa1", 5);
            grupa1.LiczbaMiejsc = 10;

            Grupa grupa2 = new Grupa("Grupa2", 8);
            grupa2.LiczbaMiejsc = 12;

            grupa1 -= "Jan Kowalski";
            bool isGreaterThan = grupa1 > grupa2;
            bool isLessThan = grupa1 < grupa2;
            Console.WriteLine(grupa1.ToString());
            Console.WriteLine(grupa2.ToString());
            Console.WriteLine("isGreaterThan: {0}", isGreaterThan);
            Console.WriteLine("isLessThan: {0}", isLessThan);
        }
    }
}
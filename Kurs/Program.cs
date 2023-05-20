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

            Console.WriteLine();
            Console.WriteLine("naciśnij klawisz aby kontynuować");
            Console.ReadKey();

            Grupa grupa = new Grupa("Grupa1", 10);
            grupa.LiczbaMiejsc = 15;


            Grupa grupa3 = new Grupa("Grupa2", 8);
            grupa3.LiczbaMiejsc = 12;

            Console.WriteLine("Czy grupa1 ma więcej miejsc niż grupa3? " + (grupa > grupa3));
            Console.WriteLine("Czy grupa1 ma mniej studentów niż grupa3? " + (grupa < grupa3));


            Grupa.Potok potok = new Grupa.Potok("INF/D/INŻ/A");
            string kodGrupy = potok.GenerujKodGrupy(2009);
            Console.WriteLine("Kod grupy: " + kodGrupy);


            Console.WriteLine();
            Console.WriteLine("naciśnij klawisz aby kontynuować");
            Console.ReadKey();



            Osoba pracownik = new Osoba("Jan", "Kowalski", "jan.kowalski@example.com");

            pracownik.PrzypiszAdres("ul. Główna 10", "Warszawa", "00-000");

            pracownik.WypiszDaneZAdresem();

            Console.ReadKey();
        }
    }
}
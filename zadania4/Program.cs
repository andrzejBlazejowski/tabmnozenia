// See https://aka.ms/new-console-template for more information

using zadania4;

namespace tabmnozenia
{
    class Program
    {
        static void Main()
        {
            testujLWymierna();

            testZespolone();
            testujHarmonogram();
        }

        public static void testZespolone()
        {

            LiczbaZespolona z1 = new LiczbaZespolona(3, 2);
            LiczbaZespolona z2 = new LiczbaZespolona(1, 4);

            LiczbaZespolona z3 = z1 + z2;
            Console.WriteLine("z3 = {0} + {1}i", z3.Re, z3.Im);
        }

        public static void testujLWymierna()
        {
            LWymierna liczba1 = new LWymierna(17, 2);
            LWymierna liczba2 = new LWymierna(14);
            LWymierna liczba3 = new LWymierna();

            Console.WriteLine("Liczba 1: ");
            liczba1.wypiszUlamek();

            Console.WriteLine("Liczba 2: ");
            liczba2.wypiszUlamek(); 

            Console.WriteLine("Liczba 3: ");
            liczba3.wypiszUlamek(); 

            Console.WriteLine();

            LWymierna suma = liczba1.dodaj(liczba2);
            Console.WriteLine("Suma: ");

            LWymierna roznica = liczba1.odjac(liczba2);
            Console.WriteLine("Różnica: ");

            LWymierna iloczyn = liczba1.razy(liczba2);
            Console.WriteLine("Iloczyn: ");

            LWymierna iloraz = liczba1.dziel(liczba2);
            Console.WriteLine("Iloraz: ");

            Console.WriteLine();

            bool mniejsza = liczba1.mniejsze(liczba2);
            Console.WriteLine("Czy liczba 1 jest mniejsza od liczby 2? " + mniejsza);

            bool wieksza = liczba1.wieksze(liczba2);
            Console.WriteLine("Czy liczba 1 jest większa od liczby 2? " + wieksza); 

            Console.WriteLine();

            LWymierna negacja = liczba1.minus();
            Console.WriteLine("Negacja liczby 1: ");
            negacja.wypiszUlamek();
        }
        public static void testujHarmonogram()
        {

            Zajecia[] mojHarmonogram = new Zajecia[5];

            mojHarmonogram[0] = new Zajecia("Matematyka", "MAT", DzienTygodnia.Poniedzialek, 8, "A101", Zaliczenie.Zaliczenie);
            mojHarmonogram[1] = new Zajecia("Informatyka", "INF", DzienTygodnia.Wtorek, 10, "B202", Zaliczenie.Egzamin);
            mojHarmonogram[2] = new Zajecia("Angielski", "ANG", DzienTygodnia.Sroda, 14, "C303", Zaliczenie.Zaliczenie);
            mojHarmonogram[3] = new Zajecia("Programowanie", "PROG", DzienTygodnia.Czwartek, 16, "D404", Zaliczenie.Egzamin);
            mojHarmonogram[4] = new Zajecia("Ekonomia", "EKO", DzienTygodnia.Piatek, 12, "E505", Zaliczenie.Zaliczenie);

            Console.WriteLine("Harmonogram zajec:");
            Console.WriteLine();

            foreach (Zajecia zajecia in mojHarmonogram)
            {
                zajecia.WypiszInformacje();
            }

            Console.WriteLine("Harmonogram wedlug dni tygodnia:");
            Console.WriteLine();


            // Sortowanie harmonogramu według dnia tygodnia, a następnie godziny
            Array.Sort(mojHarmonogram, (x, y) =>
            {
                int result = x.dzien.CompareTo(y.dzien);
                if (result == 0)
                    result = x.godzina.CompareTo(y.godzina);
                return result;
            });

            DzienTygodnia obecnyDzien = mojHarmonogram[0].dzien;

            foreach (Zajecia zajecia in mojHarmonogram)
            {
                if (zajecia.dzien != obecnyDzien)
                {
                    Console.WriteLine();
                    obecnyDzien = zajecia.dzien;
                }

                Console.WriteLine("Dzien: {0}", obecnyDzien);
                Console.WriteLine("Godzina: {0}", zajecia.godzina);
                zajecia.WypiszInformacje();
            }

            Console.ReadLine();
        }
    }

}


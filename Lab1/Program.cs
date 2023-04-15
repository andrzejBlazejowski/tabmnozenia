// See https://aka.ms/new-console-template for more information

using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie_1_5();
        }

        static void Zadanie_1_1()
        {
            Console.WriteLine("podaj tekst do wypisania : ");
            string input = Console.ReadLine();

            Console.WriteLine("wprowadziłeś następujący tekst : ");
            Console.WriteLine(input);
        }

        static void Zadanie_1_2()
        {
            Console.WriteLine("Podaj wartość w km/h, jaką chcesz przeliczyć na m/s");

            string consoleInput = Console.ReadLine();

            double kmPerH;

            if (double.TryParse(consoleInput, out kmPerH))
            {
                Console.WriteLine("Przeliczona wartość wynosi : {0}", convertKmPerHToMPerS(kmPerH));
            }
            else
            {
                Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
            }
        }
        static double convertKmPerHToMPerS(double kmPerH)
        {
            return kmPerH * 0.277778;
        }
        static void Zadanie_1_3()
        {
            Console.WriteLine("Podaj kwote Netto : ");
            string consoleInput = Console.ReadLine();
            double netto;
            if (!double.TryParse(consoleInput, out netto))
            {
                Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
                return;
            }
            Console.WriteLine("");

            Console.WriteLine("PodajStawke Vat : ");
            consoleInput = Console.ReadLine();
            double vatRate;
            if (!double.TryParse(consoleInput, out vatRate))
            {
                Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
                return;
            }
            Console.WriteLine("");


            Console.WriteLine("Dla Podanych wartości kwota VAT wynosi: {0:F2}, natomiast kwota brutto wynosi: {1:F2}", 
                getVatValue(netto,vatRate), 
                getGrossValue(netto, vatRate));
        }
        static double getVatValue(double nettoValue, double vatRate) 
        {
            return nettoValue * vatRate / 100;
        }
        static double getGrossValue(double nettoValue, double vatRate)
        {
            return getVatValue(nettoValue, vatRate) + nettoValue;
        }
        static void Zadanie_1_4()
        {
            Console.WriteLine("Podaj liczbę naturalną, a napiszę Ci czy jest parzysta: ");
            string consoleInput = Console.ReadLine();
            int number;
            if (!int.TryParse(consoleInput, out number))
            {
                Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
                return;
            }
            Console.WriteLine("");

            if (number % 2 == 0)
                Console.WriteLine("liczba jest parzysta");
            else 
                Console.WriteLine("liczba jest nie parzysta");
        }
        static void Zadanie_1_5()
        {
            Console.WriteLine("Podaj liczbę naturalną (w zakresie od 1 do 7) a napiszę Ci jaki dzień tygodnia reprezentuje");
            string consoleInput = Console.ReadLine();
            int weekDay;
            if (!int.TryParse(consoleInput, out weekDay))
            {
                Console.WriteLine("Niestety niepoprawną liczbę");
                return;
            }
            if (weekDay > 7  || weekDay < 1)
            {
                Console.WriteLine("Niestety wprowadziłeś liczbę z poza zakresu (1-7)");
                return;
            }

            Console.WriteLine("");
            switch (weekDay)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
            }
        }
    }
}
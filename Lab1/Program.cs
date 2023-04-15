// See https://aka.ms/new-console-template for more information

using System;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 14;
            Zadanie_1_10(number);
            Zadanie_1_10(3);
            Zadanie_1_10(43);
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
        static void Zadanie_1_6(double height, int weight)
        {
            Console.WriteLine("**************  Obliczanie BMI  **************");
            Console.Write("Podaj wzrost w metrach np. 1,60           -> {height:F2}", height);

            Console.Write("Podaj swoją wage w kilogramach np. 60     -> {weight:F2}", weight);

            double BMI = getBMI(height, weight);
            string BMIMessage = getBMIText(BMI);

            Console.WriteLine("Twój BMI wynosi {0:F2}  Wskazuje to na: {1}", BMI, BMIMessage);
        }
        static double getBMI(double height, int weight)
        {
            return weight / (height * height);
        }
        static string getBMIText(double BMI)
        {
            switch (BMI)
            {
                case <= 15:
                    return "wygłodzenie";
                case >15 and <= 17.4:
                    return "wychudzenie (spowodowane zwykle przez ciężką chorobe lub anoreksję)";
                case > 17.4 and <= 18.5:
                    return "niedowaga";
                case > 18.5 and <= 24.9:
                    return "wartość prawidłowa";
                case > 24.9 and <= 29.9:
                    return "nadwaga";
                case > 29.9 and <= 34.9:
                    return "I stopień otyłości";
                case > 34.9 and <= 39.9:
                    return "II stopień otyłości";
                case > 39.9:
                    return "III stopień otyłości (Otyłość skrajna)";
                default:
                    return "Niestety coś poszło nie tak.";
            }
        }
        static void Zadanie_1_7()
        {
            Console.WriteLine("**************  Obliczanie BMI  **************");
            Console.Write("Podaj wzrost w metrach np. 1,60           -> ");

            string consoleInput = Console.ReadLine();
            double height;
            if (!double.TryParse(consoleInput, out height))
            {
                Console.WriteLine("Niestety niepoprawną liczbę");
                return;
            }

            Console.Write("Podaj swoją wage w kilogramach np. 60     -> ");
            consoleInput = Console.ReadLine();
            int weight;
            if (!int.TryParse(consoleInput, out weight))
            {
                Console.WriteLine("Niestety niepoprawną liczbę");
                return;
            }

            double BMI = getBMI(height, weight);
            string BMIMessage = getBMIText(BMI);

            Console.WriteLine("Twój BMI wynosi {0:F2}  Wskazuje to na: {1}", BMI, BMIMessage);
        }

        static void Zadanie_1_8_A()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
        }
        static void Zadanie_1_8_B()
        {
            int i = 0;
            while (i < 10)
            {
                Console.Write(i);
                i++;
            }
            Console.WriteLine();

        }
        static void Zadanie_1_8_C()
        {
            int i = 0;
            do
            {
                Console.Write(i);
                i++;
            } while (i < 10);
            Console.WriteLine();

        }

        static void Zadanie_1_9_A(int maxValue)
        {
            int sum = 0;
            int topN;
            for (int i = 0; ; i++)
            {
                if((sum + i) <= maxValue)
                    sum += i;
                else 
                {
                    topN = i - 1;
                    break;
                }
            }
            Console.WriteLine("największa suma nie przekraczająca n ({0}) wynosi {1}, natomiast n wynosi : {2}", maxValue, sum, topN);
        }
        static void Zadanie_1_9_B(int maxValue)
        {
            int sum = 0;
            int topN;
            int i = 0;
            while (true)
            {
                if ((sum + i) <= maxValue)
                    sum += i;
                else
                {
                    topN = i - 1;
                    break;
                }
                i++;
            }
            Console.WriteLine("największa suma nie przekraczająca n ({0}) wynosi {1}, natomiast n wynosi : {2}", maxValue, sum, topN);

        }
        static void Zadanie_1_9_C(int maxValue)
        {
            int sum = 0;
            int topN;
            int i = 0;
            do
            {
                if ((sum + i) <= maxValue)
                    sum += i;
                else
                {
                    topN = i - 1;
                    break;
                }
                i++;
            } while (true);
            Console.WriteLine("największa suma nie przekraczająca n ({0}) wynosi {1}, natomiast n wynosi : {2}", maxValue, sum, topN);
        }
        static void Zadanie_1_10(int number)
        {
            if ( number > 99 || number < 1 ) 
            {
                Console.WriteLine("Nieprawidłowe dane wejściowe");
                return;
            }
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            Console.WriteLine("{0}",getNumberInWords(firstDigit, secondDigit));

        }
        static string getNumberInWords(int firstDigit, int secondDigit)
        {
            if (firstDigit != 1) { 
                return getTensName(firstDigit) + " " + getUnityName(secondDigit);
            }
            return getTennsName(secondDigit) ;
        }
        static string getTennsName(int tens)
        {
            switch (tens)
            {
                case 1:
                    return "jedenaście";
                case 2:
                    return "dwanaście";
                case 3:
                    return "trzynaście";
                case 4:
                    return "czternaście";
                case 5:
                    return "piętnaście";
                case 6:
                    return "szesnaście";
                case 7:
                    return "siedemnaście";
                case 8:
                    return "osiemnaście";
                case 9:
                    return "dziewiętnaście";
                default:
                    return "";
            }
        }
        static string getTensName(int tens)
        {
            switch (tens)
            {
                case 1:
                    return "dziesięć";
                case 2:
                    return "dwadzieścia";
                case 3:
                    return "trzydzieści";
                case 4:
                    return "czterydzieści";
                case 5:
                    return "pięćdziesiąt";
                case 6:
                    return "sześćdziesiąt";
                case 7:
                    return "siedemdziesiąt";
                case 8:
                    return "osiemdziesiąt";
                case 9:
                    return "dziewięćdziesiąt";
                default:
                    return "";
            }
        }
        static string getUnityName(int unity)
        {
            switch (unity)
            {
                case 1:
                    return "jeden";
                case 2:
                    return "dwa";
                case 3:
                    return "trzy";
                case 4:
                    return "cztery";
                case 5:
                    return "pięć";
                case 6:
                    return "sześć";
                case 7:
                    return "siedem";
                case 8:
                    return "osiem";
                case 9:
                    return "dziewięć";
                default:
                    return "";
            }
        }
    }
}
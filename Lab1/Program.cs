// See https://aka.ms/new-console-template for more information

using System;
using System.Text.RegularExpressions;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie_1_1();
            //Zadanie_1_2();
            //Zadanie_1_3();
            //Zadanie_1_4();
            //Zadanie_1_5();
            //Zadanie_1_6(1.4,60);
            //Zadanie_1_7();
            //Zadanie_1_8_A();
            //Zadanie_1_8_B();
            //Zadanie_1_8_C();
            //Zadanie_1_9_A(22);
            //Zadanie_1_9_B(22);
            //Zadanie_1_9_C(22);
            //Zadanie_1_10(4);
            //Zadanie1_11_A();
            //Zadanie1_11_B();
            //Zadanie1_11_B();
            //Zadanie2_1();
            //Zadanie2_2();
            //Zadanie2_3();
            Zadanie2_4();
        }

        static void Zadanie_1_1()
        {
            Console.WriteLine("podaj tekst do wypisania : ");
            string input = Console.ReadLine();

            Console.WriteLine("wprowadziłeś następujący tekst : ");
            Console.WriteLine(input);
            Console.ReadKey();
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
            Console.ReadKey();
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
                getVatValue(netto, vatRate),
                getGrossValue(netto, vatRate));
            Console.ReadKey();
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
            Console.ReadKey();
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
            if (weekDay > 7 || weekDay < 1)
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
            Console.ReadKey();
        }
        static void Zadanie_1_6(double height, int weight)
        {
            Console.WriteLine("**************  Obliczanie BMI  **************");
            Console.Write("Podaj wzrost w metrach np. 1,60           -> {height:F2}", height);

            Console.Write("Podaj swoją wage w kilogramach np. 60     -> {weight:F2}", weight);

            double BMI = getBMI(height, weight);
            string BMIMessage = getBMIText(BMI);

            Console.WriteLine("Twój BMI wynosi {0:F2}  Wskazuje to na: {1}", BMI, BMIMessage);
            Console.ReadKey();
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
                case > 15 and <= 17.4:
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
            Console.ReadKey();
        }

        static void Zadanie_1_8_A()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.ReadKey();
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
            Console.ReadKey();

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
            Console.ReadKey();

        }

        static void Zadanie_1_9_A(int maxValue)
        {
            int sum = 0;
            int topN;
            for (int i = 0; ; i++)
            {
                if ((sum + i) <= maxValue)
                    sum += i;
                else
                {
                    topN = i - 1;
                    break;
                }
            }
            Console.WriteLine("największa suma nie przekraczająca n ({0}) wynosi {1}, natomiast n wynosi : {2}", maxValue, sum, topN);
            Console.ReadKey();
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

            Console.ReadKey();
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
            Console.ReadKey();
        }
        static void Zadanie_1_10(int number)
        {
            if (number > 99 || number < 1)
            {
                Console.WriteLine("Nieprawidłowe dane wejściowe");
                return;
            }
            int firstDigit = number / 10;
            int secondDigit = number % 10;
            Console.WriteLine("{0}", getNumberInWords(firstDigit, secondDigit));

            Console.ReadKey();
        }
        static string getNumberInWords(int firstDigit, int secondDigit)
        {
            if (firstDigit != 1)
            {
                return getTensName(firstDigit) + " " + getUnityName(secondDigit);
            }
            return getTennsName(secondDigit);
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


        static void Zadanie1_11_A()
        {
            string[] cards = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Podaj karte (as, król, dama, walet, dziesiątka lub dziewiątka): ");
                string consoleInput = Console.ReadLine();
                if (!isCardValid(consoleInput))
                {
                    Console.WriteLine("Podałeś nie właściwą karte (as, król, dama, walet, dziesiątka lub dziewiątka)");
                    return;
                }
                else {
                    cards[i] = consoleInput;
                }
            }
            int points = getPointsFromNames(cards);

            Console.WriteLine("Uzyskałeś następującą ilość punktów : {0}", points);
            Console.ReadKey();
        }
        static bool isCardValid(string cardName)
        {
            switch (cardName)
            {
                case "as":
                case "dziesiątka":
                case "dziewiątka":
                case "król":
                case "dama":
                case "walet":
                    return true;
                default:
                    return false;
            }
        }
        static int getPointsFromName(string name)
        {
            switch (name)
            {
                case "as":
                    return 11;
                case "dziesiątka":
                    return 10;
                case "król":
                    return 4;
                case "dama":
                    return 3;
                case "walet":
                    return 2;
                default:
                    return 0;
            }

        }
        static int getPointsFromNames(string names)
        {           
            return getPointsFromNames(names.Split(","));
        }
        static int getPointsFromNames(string[] names)
        {
            int sum = 0;
            for (int i = 0; i < names.Length; i++)
            {
                sum += getPointsFromName(names[i]);
            }
            return sum;
        }
        static void Zadanie1_11_B()
        {
            int cardsLength = 0;

            Console.Write("Podaj ilość kart do wylosowania: ");
            string consoleInput = Console.ReadLine();
            if (!int.TryParse(consoleInput, out cardsLength))
            {
                Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
                return;
            }

            Console.Write("Wylosowano karty : ");
            string[] cards = new string[cardsLength];
            for (int i = 0; i < cardsLength; i++)
            {
                cards[i] = GetRandomStringCardName();
                Console.Write("{0}{1} ", cards[i], i==cardsLength? "" : ",");
            }
            int points = getPointsFromNames(cards);
            Console.WriteLine();

            Console.WriteLine("Uzyskałeś następującą ilość punktów : {0}", points);

            Console.ReadKey();
        }
        static string GetRandomStringCardName()
        {
            string[] strings = new string[] { "as", "król", "dama", "walet", "dziesiątka", "dziewiątka" };
            Random random = new Random();
            int index = random.Next(strings.Length);
            return strings[index];
        }

        static void Zadanie2_1()
        {
            int arrLength;
            Console.Write("Podaj ilość elementów tablicy: ");
            string consoleInput = Console.ReadLine();
            if (!int.TryParse(consoleInput, out arrLength))
            {
                Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
                return;
            }

            int[] elements = new int[arrLength];
            for (int i = 0; i < arrLength; i++)
            {
                int elem;
                
                Console.Write("Podaj kolejny element : ");
                consoleInput = Console.ReadLine();
                if (!int.TryParse(consoleInput, out elem))
                {
                    Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
                    return;
                }
                elements[i] = elem;
            }
            
            int sum = getSum(elements);
            double avarage = getAverage(elements);

            Console.WriteLine();
            Console.Write("suma z podanych elementów jest równa: {0}, \n natomiast średnia z podanych elementów wynosi : {1:F2}", sum, avarage);

            Console.ReadKey();
        }
        static int getSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        static double getAverage(int[] array)
        {
            int sum = getSum(array);
            return (double)sum / array.Length;
        }
        static void Zadanie2_2()
        {
            Console.Write("Podaj tekst : ");
            string consoleInput = Console.ReadLine();
            string[] inputText = consoleInput.Split();

            Console.WriteLine();
            Console.Write("tekst wynikowy : ");
            for (int i = 0; i < inputText.Length; i++)
            {
                inputText[i] = clearStringFromSpecialChars(inputText[i].Trim());
                Console.Write(inputText[i]);
            }
            Console.ReadKey();
        }
        static string clearStringFromSpecialChars(string input)
        {
            return Regex.Replace(input, "[^a-zA-Z0-9_.]+", "", RegexOptions.Compiled);
        }
        static void Zadanie2_3()
        {
            int rowsCount;
            int colsCount;

            Console.Write("Podaj ilość wierszy: ");
            string consoleInput = Console.ReadLine();
            if (!int.TryParse(consoleInput, out rowsCount) || rowsCount > 99 || rowsCount < 1)
            {
                Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
                return;
            }
            Console.Write("Podaj ilość kolumn: ");
            consoleInput = Console.ReadLine();
            if (!int.TryParse(consoleInput, out colsCount) || colsCount > 99 || colsCount < 1)
            {
                Console.WriteLine("Niestety wprowadziłeś niepoprawne dane");
                return;
            }

            int[,] tabliczby = new int[rowsCount+1, colsCount+1];

            for (int i = 1; i <= rowsCount; i++)
            {
                for (int j = 1; j <= colsCount; j++)
                {
                    tabliczby[i, j] = j * i;
                    Console.Write("{0,3:D}", tabliczby[i, j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static void Zadanie2_4()
        {
            int[][] numbers = new int[5][];

            for (int i = 0; i < numbers.Length; i++)
            {
                string numberStr = getRandomInt(0, 1000).ToString();

                int[] digits = new int[numberStr.Length];
                for (int j = 0; j < digits.Length; j++)
                {
                    digits[j] = numberStr[j];
                }
                numbers[i] = digits;
            }
        }
        static int getRandomInt(int start, int end)
        {
            Random random = new Random();
            return random.Next(start, end + 1);
        }
    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.narzedzia
{
    public class RandomUtility
    {
        private static Random random = new Random();

        public static int randomInt(int a, int b)
        {
            return random.Next(a, b + 1);
        }

        public static decimal randomDecimal(decimal a, decimal b)
        {
            decimal range = Math.Abs(b - a);
            decimal randomValue = (decimal)(random.NextDouble() * (double)range) + a;
            return randomValue;
        }

        public static double randomDouble(double a, double b)
        {
            double range = Math.Abs(b - a);
            double randomValue = (random.NextDouble() * range) + a;
            return randomValue;
        }

        public static string randomString(int n)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            char[] randomChars = new char[n];
            for (int i = 0; i < n; i++)
            {
                randomChars[i] = chars[random.Next(chars.Length)];
            }
            return new string(randomChars);
        }

        public static T[] randomFromArray<T>(int n, T[] array, bool rep)
        {
            if (rep)
            {
                T[] randomElements = new T[n];
                for (int i = 0; i < n; i++)
                {
                    randomElements[i] = array[random.Next(array.Length)];
                }
                return randomElements;
            }
            else
            {
                if (n > array.Length)
                {
                    n = array.Length;
                }
                T[] copyArray = new T[array.Length];
                Array.Copy(array, copyArray, array.Length);
                T[] randomElements = new T[n];
                for (int i = 0; i < n; i++)
                {
                    int randomIndex = random.Next(array.Length - i);
                    randomElements[i] = copyArray[randomIndex];
                    copyArray[randomIndex] = copyArray[array.Length - i - 1];
                }
                return randomElements;
            }
        }
    }
}

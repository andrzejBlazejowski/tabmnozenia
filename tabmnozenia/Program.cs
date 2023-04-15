// See https://aka.ms/new-console-template for more information

namespace tabmnozenia 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] tabliczby = new int[11, 11];

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    tabliczby[i, j] = j*i;
                }
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write("{0,3:D}", tabliczby[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
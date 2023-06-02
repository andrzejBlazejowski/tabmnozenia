using System;
using System.Collections.Generic;

namespace Lab5
{

    public class Zestawienie<T>
    {
        private T[] dane;

        public Zestawienie(T[] dane)
        {
            this.dane = dane;
        }

        public void GenerujZestawienie()
        {
            if (dane.Length == 0)
            {
                Console.WriteLine("Brak danych ");
                return;
            }

            var properties = typeof(T).GetProperties();

            foreach (var property in properties)
            {
                Console.Write("{0,-15}", property.Name);
            }
            Console.WriteLine();

            foreach (var element in dane)
            {
                foreach (var property in properties)
                {
                    Console.Write("{0,-15}", property.GetValue(element));
                }
                Console.WriteLine();
            }
        }
    }
}

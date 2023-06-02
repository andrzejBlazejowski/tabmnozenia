using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{

    public class MojaData
    {
        public DateTime Data { get; set; }

        public MojaData(DateTime data)
        {
            Data = data;
        }

        // Niejawna konwersja z typu MojaData do liczby całkowitej
        public static implicit operator int(MojaData mojaData)
        {
            DateTime dzis = DateTime.Today;
            int lata = dzis.Year - mojaData.Data.Year;
            if (dzis.Month < mojaData.Data.Month || (dzis.Month == mojaData.Data.Month && dzis.Day < mojaData.Data.Day))
            {
                lata--;
            }
            return lata;
        }

        // Jawną konwersja z typu MojaData do liczby typu float
        public static explicit operator float(MojaData mojaData)
        {
            DateTime dzis = DateTime.Today;
            TimeSpan roznica = dzis - mojaData.Data;
            float lata = (float)roznica.TotalDays / 365;
            return lata;
        }
    }
}

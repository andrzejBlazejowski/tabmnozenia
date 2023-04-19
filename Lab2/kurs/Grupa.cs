using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.kurs
{
    public class Grupa
    {
        public string Nazwa { get; set; }
        public int LiczbaStudentow { get; set; }

        public Grupa(string nazwa, int liczbaStudentow)
        {
            Nazwa = nazwa;
            LiczbaStudentow = liczbaStudentow;
        }

        public override string ToString()
        {
            return $"{Nazwa} ({LiczbaStudentow} studentów)";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Osoba
{
    public class Student : Osoba
    {
        public string Kierunek { get; set; }
        public int NumerS { get; set; }
         
        public Student(string imie, string nazwisko, string email, int weigth, double height, string kierunek, string numerTelefonu) : base(imie, nazwisko, email, weigth, height, numerTelefonu)
        {
            Kierunek = kierunek;
        }

        public override string ToString()
        {
            return $"{Numer}. {Imie} {Nazwisko} ({Email}), {Kierunek}, numer albumu: {NumerS}";
        }
    }
}

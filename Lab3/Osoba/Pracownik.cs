using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Osoba
{
    public class Pracownik : Osoba
    {
        public new string NumerTelefonu { get; set; }

        public Pracownik(string imie, string nazwisko, string email, int weight, double height, string numerTelefonu) : base(imie, nazwisko, email, weight, height, numerTelefonu)
        {
            NumerTelefonu = numerTelefonu;
        }

        public override string ToString()
        {
            return $"{Imie} {Nazwisko} ({Email}) - służbowy numer telefonu: {NumerTelefonu}";
        }
    }
}

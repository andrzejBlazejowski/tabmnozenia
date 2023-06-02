// See https://aka.ms/new-console-template for more information
using Lab5;

Console.WriteLine("Hello, World!");


Dane<string> daneString = new Dane<string>();
daneString.Pole = "Przykładowy tekst";
daneString.WypiszDane("Argument dla string");

Dane<int> daneInt = new Dane<int>();
daneInt.Pole = 42;
daneInt.WypiszDane(123);

Dane<double> daneDouble = new Dane<double>();
daneDouble.Pole = 3.14;
daneDouble.WypiszDane(2.71);
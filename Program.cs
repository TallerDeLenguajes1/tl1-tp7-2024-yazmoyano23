// See https://aka.ms/new-console-template for more information
using EspacioCalculadora;

Calculadora MiCalculadora = new Calculadora() ;


MiCalculadora.Sumar(5);
Console.WriteLine(MiCalculadora.Resultado);
MiCalculadora.Restar(2);
Console.WriteLine(MiCalculadora.Resultado);
MiCalculadora.Multiplicar(4);
Console.WriteLine(MiCalculadora.Resultado);

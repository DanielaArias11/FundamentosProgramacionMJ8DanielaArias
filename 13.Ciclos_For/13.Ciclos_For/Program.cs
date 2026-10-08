using System;

namespace _13.Ciclos_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int acumulador = 0;
            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }
            Console.WriteLine("La suma de los números del 1 al 5 es: " + acumulador);
        }
    }
}

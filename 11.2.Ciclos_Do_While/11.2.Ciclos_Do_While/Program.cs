using System;

namespace _11._Ciclos_Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables

            /*int Contador = 0;

            int Acumulador = 0;

            //ciclo while

            do
            {
                Contador++;
                Acumulador = Acumulador + Contador;
            }
            while (Contador < 5);

            //resultado

            Console.WriteLine("La suma es: " +  Acumulador);*/

            //variables

            /*int numero = 0;

            int acumulador = 1;

            int limite = 11;

            //interfaz usuario

            Console.WriteLine("Que tabla de numero quiere ver?");

            numero = int.Parse(Console.ReadLine());

            //ciclo

            do
            {
                Console.WriteLine(numero + " x " + acumulador + " = " + numero * acumulador);

                acumulador++;

                if (acumulador == limite)
                {
                    string pregunta = "";
                    Console.WriteLine("Desea continuar con la tabla? (si/no)");
                    pregunta = Console.ReadLine();
                    if (pregunta == "si")
                    {
                        limite = limite + 10;
                    }
                }
            }
            while (acumulador < limite);*/
            int numero = 1;

            do
            {
                bool primo = true;
                int divisor = 2;

                if (numero < 2)                {
                    primo = false;
                }
                else
                {
                    do
                    {
                        if (numero / divisor == 0)
                        {
                            primo = false;
                            break;
                        }
                    }
                    while (divisor * divisor <= numero);
                }
                if (primo == true)
                {
                    Console.WriteLine(numero);
                }
                numero++;
            }
            while (numero <= 100);
        }
    }
}

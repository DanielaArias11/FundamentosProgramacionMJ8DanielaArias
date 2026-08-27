using System;
using System.Runtime.InteropServices;


namespace _8.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Realiza un algoritmo que pida numeros enteros positivos y los sumas, hasta que se ingrese un numero entero negativo. Se debe mostrar por pantalla el total
            //se need un contador porque pide una suma de enteros 

            //        int SumaEnterosPositivos = 0;
            //        int numero = 0;

            //        Console.WriteLine("Ingrese un numero para sumar, ingrese -1 para terminar:");
            //        numero = int.Parse(Console.ReadLine());

            //        while (numero >= 0) 
            //        {
            //            SumaEnterosPositivos += numero;
            //            Console.WriteLine("Ingrese un numero para sumar, ingrese -1 para terminar:");
            //            numero = int.Parse(Console.ReadLine());
            //        }

            //        Console.WriteLine($"La suma de los numeros es:");
            //        int.Parse(Console.ReadLine()); 
            //}

            int cantidad = 0;
            int numero = 0;
            int contador = 1;
            int mayores = 0;
            int menores = 0;
            int igual = 0;

            Console.WriteLine("Ingrese cuantos numero va evaluar");
            cantidad = int.Parse(Console.ReadLine());


            while (contador >= cantidad)  
            {
                contador++;
                Console.WriteLine("Ingrese numeros al azar para evaluar" + contador);
                numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    mayores++;
                }
                else
                {
                    if (numero < 0)
                    {
                        menores++;
                    }
                    else
                    {
                        igual++;
                    }
                }

            }
                Console.WriteLine("Los numeros mayores a cero son:" + mayores);
                Console.WriteLine("Los numeros menores a cero son:" + menores);
                Console.WriteLine("Los numero igual a 0 son:" + igual);

            }
        }

    }




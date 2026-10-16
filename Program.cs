using System;
using System.Runtime.CompilerServices;

namespace _16.matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[,] numeros=new int[2,3];
            //numeros[0, 0] =  14;
            //numeros[0, 1] =  129;
            //numeros[0, 2] =  4;
            //numeros[1, 0] =  25;
            //numeros[1, 1] =  55;
            //numeros[1, 2] =  65;
            //Console.WriteLine($"El numero almacenado en numeros [1,0] es: {numeros[1,0]}");
            //char[,] simbolos = new char[3, 2];
            //for (int i=0;i<3;i++) 
            //{
            //    for (int j = 0; j < 2; j++) 
            //    {
            //        Console.WriteLine($"Escriba el caracter para los simbolos[{i},{j}]");
            //        simbolos[i,j] = char.Parse( Console.ReadLine() );
            //    }
            //}
            //Console.WriteLine();
            //for (int i = 0; i < simbolos.GetLength(0); i++)
            //{
            //    for (int j = 0; j < simbolos.GetLength(1); j++)
            //    {
            //        Console.Write($"{simbolos[i, j]} |");
            //    }
            //    Console.WriteLine();
            //}
            //string[,] nombres = {
            //                         {"Ana" , "Alba" , "Carla" , "Juan" },
            //                         {"ferney","guillermo","marta","claudia" },
            //                         {"eric","mateo","mur","last"}
            //                    };


            //int[,] matriz = new int[10, 20];

            //for (int fila = 0; fila < 10; fila++)
            //{
            //    for (int columna = 0; columna < 20; columna++)
            //    {
            //        matriz[fila, columna] = 100;
            //    }
            //}

            //for (int fila = 0; fila < 10; fila++)
            //{
            //    for (int columna = 0; columna < 20; columna++)
            //    {
            //        Console.Write(matriz[fila, columna] + " ");
            //    }

            //    Console.WriteLine();
            //}


            int[,] matriz1 = new int[2, 3];
            int[,] matriz2 = new int[2, 3];
            int[,] suma = new int[2, 3];

            Console.WriteLine("Ingrese los elementos de la primera matriz:");

            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.WriteLine($"Ingrese el elemento [{fila},{columna}]:");
                    matriz1[fila, columna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese los elementos de la segunda matriz:");

            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.WriteLine($"Ingrese el elemento [{fila},{columna}]:");
                    matriz2[fila, columna] = int.Parse(Console.ReadLine());
                }
            }

            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    suma[fila, columna] = matriz1[fila, columna] + matriz2[fila, columna];
                }
            }

            Console.WriteLine("Matriz resultante de la suma:");

            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(suma[fila, columna] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

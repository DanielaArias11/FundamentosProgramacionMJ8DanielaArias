using System;


namespace _15.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
            //encuentre y muestre el valor máximo y mínimo de los números ingresados.

            int[] enteros = new int[15];
            int maximo = enteros[0];
            int minimo = enteros[0];
            for (int i = 0; i<enteros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para la posicion {i}:");
                enteros[i]= int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < enteros.Length; i++)
            {
                if (enteros[i] > maximo)
                    maximo = enteros[i];
                if (enteros[i] < minimo)
                    minimo = enteros[i];
            }
            Console.WriteLine($"El numero maximo es: {maximo}");
            Console.WriteLine($"El numero minimo es: {minimo}");

            //2. Escribir un algoritmo que permita:
            //a.Crear dos vectores del mismo tamaño. 
            //b.Llenarlos con números.
            //c.Comparar posición por posición.
            //d.Indicar cuántos elementos son iguales

            int[] vectorA = new int[5];
            int[] vectorB = new int[5];

            Console.WriteLine($"Ingrese vectorA:");
        }
    }
}

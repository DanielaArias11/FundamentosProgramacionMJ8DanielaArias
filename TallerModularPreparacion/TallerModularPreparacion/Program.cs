using System;

namespace TallerModularPreparacion
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            

        }
        static void Main(string[] arg)
        {
            string palabra = LeerPalabra();
            char[] vector = PalabrasVector (palabra);

            int vocales, consonantes;
            ContarVocalesYConsonantes(vector.out vocales, out consonantes);
            Console.WriteLine("\n---Resultados----");
            Console.WriteLine("Palabra ingresada  :" + palabra);
            Console.WriteLine("Total de caracteres: " + vector.Length);
            Console.WriteLine("Vocales            :" + vocales);
            Console.WriteLine("Comsonantes        :" + consonantes);
            Console.ReadKey();
        }
        static string LeerPalabra()
        {
            string entrada;
            do
            {
                Console.WriteLine("Ingrese una palabra:");
                entrada = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(entrada))
                    Console.WriteLine("Error: no puede estar vacia. Intente de nuevo.");
            } while (string.IsNullOrWhiteSpace(entrada));
            return entrada.Trim();
        }

    }
}

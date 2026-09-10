using System;


namespace ParcialCiclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edad; 
            int cont4 = 0, cont5 = 0, cont6 = 0;
            int suma = 0;
            const int TOTALESTUDIANTES = 15;
            double promedio;

            for (int i = 1; i <= TOTALESTUDIANTES; i++)
            {
                Console.Write("Ingrese la edad del estudiante" + i + ": ");
                edad = int.Parse(Console.ReadLine());
                while (edad != 4 && edad != 5 && edad != 6)
                {
                    Console.WriteLine("Error: edad incorrecta. Solo se aceptan 4,  5 o  6.");
                    Console.Write("Ingrese nuevamente la edad del estudiante" + i + ":");
                    edad = int.Parse(Console.ReadLine());
                }
                  if (edad == 4)
                      cont4++;
                    else if (edad == 5)
                       cont5++;
                      else
                        cont6++;

                suma += edad;
            }

            //PROMEDIO
            promedio = (double)suma / TOTALESTUDIANTES;

           //Resultado
            Console.WriteLine("\n===== REPORTE =====");
            Console.WriteLine("Promedio de edad: " + promedio);
            Console.WriteLine("Estudiantes de 4 años: " + cont4);
            Console.WriteLine("Estudiantes de 5 años: " + cont5);
            Console.WriteLine("Estudiantes de 6 años: " + cont6);

            // Análisis de mayoría
            if (cont6 > cont4 && cont6 > cont5)
            {
                Console.WriteLine("Grupo mayor");
            }
            else if (cont4 > cont5 && cont4 > cont6)
            {
                Console.WriteLine("Grupo menor");
            }
            else
            {
                Console.WriteLine("Grupo equilibrado");
            }
        }

    }
}
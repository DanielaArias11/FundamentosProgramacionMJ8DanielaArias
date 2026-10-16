using System;
using System.Diagnostics.Eventing.Reader;

namespace TallerCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1

            //int numero1;
            //int numero2;
            //int numero3;

            //Console.WriteLine("Ingrese numero1");
            //numero1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese numero2");
            //numero2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Ingrese numero3");
            //numero3 = Convert.ToInt32(Console.ReadLine());

            //if (numero1 != numero2 && numero2 != numero3 && numero3 != numero1) 
            //{
            //    if (numero1 > numero2 && numero1 > numero3) 
            //    {
            //        Console.WriteLine("El numero mayor es" + numero1);
            //    }
            //    if (numero2 > numero1 && numero2 > numero3) 
            //    {
            //        Console.WriteLine("El numero mayor es" + numero2);
            //    }
            //    if (numero3 > numero1 && numero3 > numero2) 
            //    {
            //        Console.WriteLine("El numero mayor es" + numero3);
            //    }
            // }  
            //else
            //{
            //    Console.WriteLine("Ingrese numeros diferentes");
            //}

            //Ejercicio 2
            Console.Write("¿El personaje está invencible? (true/false): ");
bool invencible = Convert.ToBoolean(Console.ReadLine());

Random rnd = new Random();
int municion = rnd.Next(1, 11);

Console.WriteLine($"Munición disponible: {municion}");

if (invencible && municion >= 1 && municion <= 10)
{
    Console.WriteLine("El personaje está disparando");
}
            //Ejercicio 3
            Console.Write("x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.Write("x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());

Console.Write("x3: ");
double x3 = Convert.ToDouble(Console.ReadLine());
Console.Write("y3: ");
double y3 = Convert.ToDouble(Console.ReadLine());

double d12 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
double d23 = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
double d13 = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));

Console.WriteLine($"Distancia P1-P2: {d12}");
Console.WriteLine($"Distancia P2-P3: {d23}");
Console.WriteLine($"Distancia P1-P3: {d13}");

bool cumple12 = d12 + d23 > d13;
bool cumple23 = d12 + d13 > d23;
bool cumple13 = d23 + d13 > d12;

if (cumple12 && cumple23 && cumple13)
{
    Console.WriteLine("Con estas distancias se puede construir un triángulo.");
}
else
{
    Console.WriteLine("No se puede construir un triángulo.");
    if (!cumple12) Console.WriteLine("No se cumple: P1-P2 + P2-P3 debe ser mayor que P1-P3.");
    if (!cumple23) Console.WriteLine("No se cumple: P1-P2 + P1-P3 debe ser mayor que P2-P3.");
    if (!cumple13) Console.WriteLine("No se cumple: P2-P3 + P1-P3 debe ser mayor que P1-P2.");
}

            //Ejercicio 4

            Console.Write("Presione 'd' o 'i': ");
char tecla = Convert.ToChar(Console.ReadLine().ToLower());

if (tecla == 'd')
{
    Console.WriteLine("El personaje se mueve hacia la derecha");
}
else if (tecla == 'i')
{
    Console.WriteLine("El personaje se mueve hacia la izquierda");
}
else
{
    Console.WriteLine("No me puedo mover en otra dirección");
}

            //Ejercicio 5
            Random rnd = new Random();
int vidas = rnd.Next(0, 6);

Console.WriteLine($"Vidas del personaje: {vidas}");

if (vidas > 0)
{
    Console.Write("Ingrese una acción (c, x, t, i): ");
    char accion = Convert.ToChar(Console.ReadLine().ToLower());

    switch (accion)
    {
        case 'c':
            Console.WriteLine("El personaje está disparando");
            break;
        case 'x':
            Console.WriteLine("El personaje está hablando con la Rana");
            break;
        case 't':
            Console.WriteLine("El personaje está en modo Turbo");
            break;
        case 'i':
            Console.WriteLine("El personaje es Invencible");
            break;
        default:
            Console.WriteLine("Acción no válida");
            break;
    }
}
else
{
    Console.WriteLine("El personaje no posee vidas, y no puede realizar ninguna acción");
}

    //    }
    //}
}

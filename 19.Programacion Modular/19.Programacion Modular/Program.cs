using System;

namespace _19.Programacion_Modular
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MostrarMenu(); //Para Mostrar el menu, puedes mostrar cuantas veces quieras.
            RealizarOperaciones(CapturarOpcion());
        }
        //OPERACIONES
        static float Division()
        {
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero1:");
            float numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero2:");
            return numero1 / numero2;
        }

        static float Resta()
        {
            float numero1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero1:");
            float numero2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el numero2:");
            return numero1 - numero2;
        }

        static float Suma()
        {
            float suma = 0;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                suma += numero;
                Console.WriteLine("Desea seguir sumando? (s: continuar");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta =='s');
            return suma;
        }
        static float Multiplicacion()
        {
            float multiplicacion = 1;
            char respuesta = ' ';
            float numero = 0;
            do
            {
                Console.WriteLine("Ingrese un numero");
                numero = float.Parse(Console.ReadLine());
                multiplicacion *= numero;
                Console.WriteLine("Desea seguir multiplicando? (s: continuar");
                respuesta = char.Parse(Console.ReadLine());

            } while (respuesta == 's');
            return multiplicacion;
        }


        static void RealizarOperaciones(int opcion)
        {
            while (opcion != 0) //Si es diferente de cero
            {
                switch (opcion) 
                {
                    case 1:
                        Console.WriteLine($"La SUMA de los numeros ingresados es: {Suma()}");
                        break;
                    case 2:
                        Console.WriteLine($"La RESTA de los numeros 1 y 2 es: {Resta()}");
                        break;
                    case 3:
                        Console.WriteLine($"la MULTIPLICACION de los numeros es: {Multiplicacion()}"); //Para mostrar 
                        break;
                    case 4:
                        Console.WriteLine($"La DIVISION de los numeros 1 y 2 es:{Division()}");
                        break;
                }
                Console.ReadKey();//Espera que presione una tecla 
                Console.Clear();//Se borrara la pantalla
                MostrarMenu();
                opcion = CapturarOpcion();
            }
        }
        static int CapturarOpcion()
        {
            return int.Parse(Console.ReadLine());
        }

        static void MostrarMenu()
        {
            Console.WriteLine("-----------MENU------------");
            Console.WriteLine("1. Suma             2.Resta");
            Console.WriteLine("3,Multiplicacion    4.Division");
            Console.WriteLine("0. Salir");
            Console.WriteLine("---------------------------");


            Console.WriteLine("Ingrese una opcion del menu");//Capturar Opcion 
        }
    }
}

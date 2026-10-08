using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Do_while_ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variables

            int cantidad_de_usuarios = 0;

            int numero_de_cuenta = 0;

            int contador = 0;

            int acumulador_saldos = 0;

            string nombre = "";

            int saldo = 0;

            //interfaz de usuarioo en insertado de datos

            Console.WriteLine("Cuantos Usuarios van a ingresar?");

            cantidad_de_usuarios = int.Parse(Console.ReadLine());

            do
            {
                contador++;

                Console.WriteLine("Ingrese su nombre de usuario");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su numero de cuenta");
                numero_de_cuenta = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese su saldo");
                saldo = int.Parse(Console.ReadLine());

                Console.WriteLine("----------Datos de cuenta----------");
                Console.WriteLine("nombre: " + nombre);
                Console.WriteLine("numero de cuenta: " + numero_de_cuenta);
                Console.WriteLine("saldo: " + saldo);
                Console.WriteLine("------------------------------------");

                if (saldo > 3000000)
                {
                    Console.WriteLine("Es apto para el prestamo");
                }
                else
                {
                    Console.WriteLine("No es apto para el prestamo");
                }

                acumulador_saldos += saldo;

            }
            while (contador < cantidad_de_usuarios);

            Console.WriteLine("La cantidad de usuarios es: " + cantidad_de_usuarios);

            Console.WriteLine("El promedio de saldos es: " + (acumulador_saldos / cantidad_de_usuarios));

        }
    }
}

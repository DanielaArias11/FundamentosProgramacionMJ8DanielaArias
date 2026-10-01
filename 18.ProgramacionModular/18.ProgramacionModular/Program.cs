using System;


namespace _18.ProgramacionModular
{
    internal class Program
    {
        static int AñoActual = 2026;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de programacion");
            MostrarMensaje("Daniela");
            Console.WriteLine($"Daniela tiene {CalcularEdad()}");
            MostrarMensaje("Jose");
            int AñoNacimiento = 2006;
            
            CalcularEdad(AñoNacimiento, AñoActual);
            
            Console.WriteLine($"Jose tiene {CalcularEdad(AñoNacimiento,AñoActual)}años");
            MostrarMensaje("Daniela", "Arias Aguas");
            Console.ReadKey();
            BorrarPantalla();
        }
        //Funciones con parametros
        static int CalcularEdad (int AñoNacimiento, int AñoActual)
        {
            return AñoActual - AñoNacimiento;
        }
        //Funciones sin parametros
        static int CalcularEdad()
        {
            int AñoNacimiento = 2006;
            int AñoActual = 2026;
            int Edad = AñoActual - AñoNacimiento;
            return Edad;
        }
        //Procedimiento sin parametros
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Procedimiento con parametros

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso Fundamentos de Programacion");
        }

        //Procedimientos con varios parametros

        static void MostrarMensaje(String nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido,{nombre} {apellidos} al curso de Fundamentos de Programacion");
        }
    }
}

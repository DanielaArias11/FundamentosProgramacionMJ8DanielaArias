using System;


namespace _2.ConstantesTiposdeDatosyOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes simepre tiene que tener un valor
            const string iva = "19%";
            string nombre = "Daniela";
            nombre = "Ferney";
            // iva = "20%"; A una constante. no le puedo cambiar el valor 
            //Tipos de datos 
            byte dato1 = 255;
            int dato2 = -12365;
            long dato3 = 123566554;
            float dato4 = 5.3f;
            double dato5 = 12.36d;
            decimal dato6 = 12345655.5444126m;
            char dato7 = '¿'; //un solo caracter 
            string dato8 = "datos-*/*¿22654544#bnjbn'M";
            bool dato9 = true; //true or flase 
            object dato10 = new object();

            //OPERADORES
            //operdaores numericos
            //Cambio de signos 
            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11:{0}, dato12:{1}", dato11,dato12);
            //Operadoreas Arigmeticos
            int dato13 = 3 + 5;
            Console.WriteLine("La suma es:{0}", dato13);
            int dato14 = dato13 - 2;
            Console.WriteLine("La resta es:{0}", dato14);
            int dato15 = 3 * 5;
            Console.WriteLine("La multiplicacion es:{0}", dato15);
            //float dato16 =(float) 5 / 3;}
            //float dato16 = 5f / 3f;
            float dato16 = 5f / 3f;
            Console.WriteLine("La division es:{0}", dato16);


        

        }
    }
}

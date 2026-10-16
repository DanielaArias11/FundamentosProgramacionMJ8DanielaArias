using System;


namespace _15.TallerVectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // EJERCICIO 1: Encontrar el máximo y el mínimo de un vector de 15 números

int[] numeros1 = new int[15];

for (int i = 0; i < numeros1.Length; i++)
{
    Console.Write($"Ingrese el número para la posición {i}: ");
    numeros1[i] = Convert.ToInt32(Console.ReadLine());
}

int maximo = numeros1[0];
int minimo = numeros1[0];

for (int i = 1; i < numeros1.Length; i++)
{
    if (numeros1[i] > maximo)
        maximo = numeros1[i];

    if (numeros1[i] < minimo)
        minimo = numeros1[i];
}

Console.WriteLine($"El valor máximo es: {maximo}");
Console.WriteLine($"El valor mínimo es: {minimo}");


// EJERCICIO 2: Comparar dos vectores y contar los elementos iguales

Console.Write("Ingrese el tamaño de los vectores: ");
int tamanio2 = Convert.ToInt32(Console.ReadLine());

int[] vector1 = new int[tamanio2];
int[] vector2 = new int[tamanio2];

Console.WriteLine("Ingrese los números del primer vector:");
for (int i = 0; i < tamanio2; i++)
{
    Console.Write($"Posición {i}: ");
    vector1[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Ingrese los números del segundo vector:");
for (int i = 0; i < tamanio2; i++)
{
    Console.Write($"Posición {i}: ");
    vector2[i] = Convert.ToInt32(Console.ReadLine());
}

int iguales = 0;

for (int i = 0; i < tamanio2; i++)
{
    if (vector1[i] == vector2[i])
        iguales++;
}

Console.WriteLine($"Hay {iguales} elementos iguales en la misma posición.");


// EJERCICIO 3: Ingresar caracteres e invertir el vector

Console.Write("¿Cuántos caracteres desea ingresar?: ");
int tamanio3 = Convert.ToInt32(Console.ReadLine());

char[] original = new char[tamanio3];
char[] invertido = new char[tamanio3];

for (int i = 0; i < tamanio3; i++)
{
    Console.Write($"Ingrese el carácter para la posición {i}: ");
    original[i] = Convert.ToChar(Console.ReadLine());
}

for (int i = 0; i < tamanio3; i++)
{
    invertido[i] = original[tamanio3 - 1 - i];
}

Console.Write("Vector original: ");
foreach (char caracter in original)
    Console.Write(caracter + " ");

Console.WriteLine();

Console.Write("Vector invertido: ");
foreach (char caracter in invertido)
    Console.Write(caracter + " ");

Console.WriteLine();


// EJERCICIO 4: Llenar un vector aleatorio y buscar un número

int[] numeros4 = new int[20];
Random rnd4 = new Random();

for (int i = 0; i < numeros4.Length; i++)
{
    numeros4[i] = rnd4.Next(0, 51);
}

Console.Write("Ingrese el número que desea buscar: ");
int buscado = Convert.ToInt32(Console.ReadLine());

int posicion = -1;

for (int i = 0; i < numeros4.Length; i++)
{
    if (numeros4[i] == buscado && posicion == -1)
        posicion = i;
}

if (posicion == -1)
{
    Console.WriteLine("-1: el número no se encuentra en el vector.");
}
else
{
    Console.WriteLine($"El número se encuentra en la posición {posicion}.");
}

Console.Write("Vector: ");
for (int i = 0; i < numeros4.Length; i++)
{
    if (numeros4[i] == buscado && posicion != -1)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write($"[{numeros4[i]}] ");
        Console.ResetColor();
    }
    else
    {
        Console.Write($"{numeros4[i]} ");
    }
}

Console.WriteLine();


// EJERCICIO 5: Crear un vector impar con un número en el centro

int tamanio5;

do
{
    Console.Write("Ingrese un tamaño impar mayor que 1: ");
    tamanio5 = Convert.ToInt32(Console.ReadLine());
} while (tamanio5 <= 1 || tamanio5 % 2 == 0);

int[] numeros5 = new int[tamanio5];
int mitad = tamanio5 / 2;

Console.Write("Ingrese el número para la posición central: ");
int central = Convert.ToInt32(Console.ReadLine());

numeros5[mitad] = central;

for (int i = mitad - 1; i >= 0; i--)
{
    numeros5[i] = numeros5[i + 1] - 1;
}

for (int i = mitad + 1; i < tamanio5; i++)
{
    numeros5[i] = numeros5[i - 1] + 1;
}

Console.WriteLine("Vector resultante:");
foreach (int numero in numeros5)
    Console.Write(numero + " ");

Console.WriteLine();


// EJERCICIO 6: Crear dos vectores aleatorios y combinarlos

Console.Write("Ingrese el rango del primer vector: ");
int rango1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Ingrese el rango del segundo vector: ");
int rango2 = Convert.ToInt32(Console.ReadLine());

if (rango1 < 0 || rango2 < 0)
{
    Console.WriteLine("Los rangos deben ser números no negativos.");
    return;
}

int[] vector6a = new int[rango1];
int[] vector6b = new int[rango2];
int[] combinado = new int[rango1 + rango2];

Random rnd6 = new Random();

for (int i = 0; i < vector6a.Length; i++)
{
    vector6a[i] = rnd6.Next(0, rango1 + 1);
    combinado[i] = vector6a[i];
}

for (int i = 0; i < vector6b.Length; i++)
{
    vector6b[i] = rnd6.Next(rango2, rango2 * 2 + 1);
    combinado[rango1 + i] = vector6b[i];
}

Console.WriteLine("Primer vector:");
foreach (int numero in vector6a)
    Console.Write(numero + " ");

Console.WriteLine("\nSegundo vector:");
foreach (int numero in vector6b)
    Console.Write(numero + " ");

Console.WriteLine("\nVector combinado:");
foreach (int numero in combinado)
    Console.Write(numero + " ");

Console.WriteLine();


// EJERCICIO 7: Contar los nombres que empiezan con una letra

Console.Write("¿Cuántos nombres desea ingresar?: ");
int tamanio7 = Convert.ToInt32(Console.ReadLine());

string[] nombres7 = new string[tamanio7];

for (int i = 0; i < nombres7.Length; i++)
{
    Console.Write($"Ingrese el nombre {i + 1}: ");
    nombres7[i] = Console.ReadLine() ?? "";
}

Console.Write("Ingrese la letra que desea buscar: ");
char letra = Convert.ToChar(Console.ReadLine()!.ToLower());

int cantidadNombres = 0;

foreach (string nombre in nombres7)
{
    if (nombre.Length > 0 && char.ToLower(nombre[0]) == letra)
        cantidadNombres++;
}

Console.WriteLine($"{cantidadNombres} nombre(s) empiezan con la letra '{letra}'.");


// EJERCICIO 8: Identificar nombres repetidos y contar cuántas veces aparecen

Console.Write("¿Cuántos nombres desea ingresar?: ");
int tamanio8 = Convert.ToInt32(Console.ReadLine());

string[] nombres8 = new string[tamanio8];

for (int i = 0; i < nombres8.Length; i++)
{
    Console.Write($"Ingrese el nombre {i + 1}: ");
    nombres8[i] = (Console.ReadLine() ?? "").Trim();
}

bool[] revisados = new bool[tamanio8];
bool hayRepetidos = false;

for (int i = 0; i < nombres8.Length; i++)
{
    if (revisados[i])
        continue;

    int cantidad = 1;

    for (int j = i + 1; j < nombres8.Length; j++)
    {
        if (string.Equals(nombres8[i], nombres8[j],
                          StringComparison.OrdinalIgnoreCase))
        {
            cantidad++;
            revisados[j] = true;
        }
    }

    if (cantidad > 1)
    {
        Console.WriteLine($"\"{nombres8[i]}\" aparece {cantidad} veces.");
        hayRepetidos = true;
    }
}

if (!hayRepetidos)
    Console.WriteLine("No hay nombres repetidos.");

            
        }
    }
}

﻿// See https://aka.ms/new-console-template for more information

/* --------------- Ejercicio 1 estructuras de decisión con IF ----------

string inputTexto="a";
do
{
    Console.Write("Texto: ");
    inputTexto = Console.ReadLine();
    Console.Clear();
} while (inputTexto == "");


Console.WriteLine("1) To Upper");
Console.WriteLine("2) To lower");
Console.WriteLine("3) Length");



ConsoleKeyInfo opcion = Console.ReadKey();

if (opcion.Key == ConsoleKey.D1)
{
    Console.Clear();
    Console.WriteLine(inputTexto.ToUpper());
}

else if (opcion.Key == ConsoleKey.D2)
{
    Console.Clear();
    Console.WriteLine(inputTexto.ToLower());
}

else if (opcion.Key == ConsoleKey.D3)
{
    Console.Clear();
    int largo = inputTexto.Length;
    Console.WriteLine(largo);
}
--------------------------------------------------------------------- */

//  Ejercicio 2 estructuras de decisión con CASE 


/*
string inputTexto="s";
do
{
    Console.Write("Texto: ");
    inputTexto = Console.ReadLine();
    Console.Clear();
} while (inputTexto == "");


Console.WriteLine("1) To Upper");
Console.WriteLine("2) To lower");
Console.WriteLine("3) Length");



ConsoleKeyInfo opcion = Console.ReadKey();

Console.Clear();

switch (opcion.Key)
{
    case ConsoleKey.D1:
    Console.WriteLine(inputTexto.ToUpper());
    break;

    case ConsoleKey.D2:
    Console.WriteLine(inputTexto.ToLower());
    break;

    case ConsoleKey.D3:
    int largo = inputTexto.Length;
    Console.WriteLine(largo);
    break;

    default: Console.WriteLine("Ingrese una opción válida");
    break;
}

*/



/* EJERCICIO 3

int cantIteraciones = 5;
string[] arreglo = new string[cantIteraciones];


for (int i =0; i < cantIteraciones; i++)
{
    Console.Write("Ingrese la posición {0} del arreglo: ", i);
    arreglo[i] = Console.ReadLine();
    Console.WriteLine ("");
}

Console.Clear ();

for (int i = 0; i < cantIteraciones; i++)
{
    Console.Write("Posición {0} del arreglo: ", i);
    Console.WriteLine(arreglo[i]);
    Console.WriteLine("");
}

*/



















// Ejercicio 4(9)

Console.WriteLine("Ingrese un numero de filas");
int filas = Int32.Parse(Console.ReadLine());
Console.WriteLine();
int cantEstrellitas = 1, totalEstrellitas = 1 + 2 * (filas - 1);
for (int i = 1; i <= filas; i++)
{
    blanco(totalEstrellitas, cantEstrellitas);
    estrellita(cantEstrellitas);
    blanco(totalEstrellitas, cantEstrellitas);
    cantEstrellitas += 2;
    Console.WriteLine();
}
       

        static void estrellita(int cantEstrellitas)
{
    for (int j = 1; j <= cantEstrellitas; j++)
    {
        Console.Write("*");
    }
}

static void blanco(int totalEstrellitas, int cantEstrellitas)
{
    int diferenciaEstrellitas = totalEstrellitas - cantEstrellitas;
    for (int j = 1; j <= (diferenciaEstrellitas / 2); j++)
    {
        Console.Write(" ");
    }

}


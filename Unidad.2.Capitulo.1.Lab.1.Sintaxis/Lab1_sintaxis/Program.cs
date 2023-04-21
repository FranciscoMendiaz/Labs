// See https://aka.ms/new-console-template for more information

/* --------------- Ejercicio 1 estructuras de decisión con IF ----------

string inputTexto="negros";
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

//  Ejercicio 1 estructuras de decisión con CASE 


string inputTexto="negros";
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




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


--------------- Ejercicio 2 estructuras de decisión con CASE ----------



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




--------------- EJERCICIO 3 --------------------------------------------------

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




--------------- Ejercicio 4 (1) --------------------------------------------------------------------------------

Console.Write("Primer Numero a Sumar: ");
float num1 = float.Parse(Console.ReadLine());

Console.Write("Segundo Numero a Sumar: ");
float num2 = float.Parse(Console.ReadLine());

float suma = num1 + num2;

Console.WriteLine("La suma de " + num1 + " más " + num2 + " da como resultado " + suma);


--------------- Ejercicio 4 (2)--------------------------------------------------------------------------------

int year = 3;

do {Console.Write("Año: ");
    year = int.Parse(Console.ReadLine());}while (year < 0);

esBiciesto(year);


static void esBiciesto(int y)
{
    if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0)) Console.WriteLine("El año " + y + " es biciesto");
    else Console.WriteLine("El año " + y + " NO es biciesto"); 



--------------- Ejercicio 4 (3) --------------------------------------------------------------------------------

int v1 = 0;
int v2 = 1;


Console.WriteLine("Hasta que número desea sumar la sucesión: ");
int n = Int32.Parse(Console.ReadLine());
Console.Clear();



for (int i = 0; i <= n; i++)
{
   int temp = v1;
    v1 = v2;
    v2 = temp + v1;
    Console.WriteLine(v1);

}

--------------- Ejercicio 4 (4) --------------------------------------------------------------------------------

for(int i=1; i <=100;i++)
{
    if (i % 2 == 0) { Console.WriteLine("El número " + i + " es par."); }
}

--------------- Ejercicio 4 (5) --------------------------------------------------------------------------------

string month;

Console.Write("Mes: ");
month = Console.ReadLine();

switch (month)
{
    case ("Enero"):
        Console.WriteLine("Mes: {0} ; Número 1", month);
        break;

    case ("Febrero"):
        Console.WriteLine("Mes: {0} ; Número 2", month);
        break;


    case ("Marzo"):
    Console.WriteLine("Mes: {0} ; Número 3", month);
    break;
    
    case ("Abril"):
        Console.WriteLine("Mes: {0} ; Número 4", month);
        break;

    case ("Mayo"):
        Console.WriteLine("Mes: {0} ; Número 5", month);
        break;


    case ("Junio"):
        Console.WriteLine("Mes: {0} ; Número 6", month);
        break;

    case ("Julio"):
        Console.WriteLine("Mes: {0} ; Número 7", month);
        break;

    case ("Agosto"):
        Console.WriteLine("Mes: {0} ; Número 8", month);
        break;


    case ("Septiembre"):
        Console.WriteLine("Mes: {0} ; Número 9", month);
        break;

    case ("Octubre"):
        Console.WriteLine("Mes: {0} ; Número 10", month);
        break;

    case ("Noviembre"):
        Console.WriteLine("Mes: {0} ; Número 11", month);
        break;


    case ("Diciembre"):
        Console.WriteLine("Mes: {0} ; Número 12", month);
        break;

    default: Console.WriteLine("Mes inválido");
        break;

} 


--------------- Ejercicio 4 (8) --------------------------------------------------------------------------------
int attempts = 0;
string password = "utnFRRO";
string text;


do
{
    text = submitPassword();
} while ((text != password) && (attempts<4));


if ((attempts <= 4)&&(text==password)) Console.WriteLine("Correct Password Submitted");
else Console.WriteLine("Too many failed attempts");


string submitPassword()
{
    string passAttempt;
    Console.Write("Password: ");
    passAttempt = Console.ReadLine();   
    attempts++;
    Console.Clear();
    return passAttempt;
}

--------------------------------------------------------------------------------------------------------------*/


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
























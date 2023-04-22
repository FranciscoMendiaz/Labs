// See https://aka.ms/new-console-template for more information

/* Ejercicio 4 (1)
Console.Write("Primer Numero a Sumar: ");
float num1 = float.Parse(Console.ReadLine());

Console.Write("Segundo Numero a Sumar: ");
float num2 = float.Parse(Console.ReadLine());

float suma = num1 + num2;

Console.WriteLine("La suma de " + num1 + " más " + num2 + " da como resultado " + suma); */


/* Ejercicio 4 (2)

int year = 3;

do {Console.Write("Año: ");
    year = int.Parse(Console.ReadLine());}while (year < 0);

esBiciesto(year);


static void esBiciesto(int y)
{
    if (((y % 4 == 0) && (y % 100 != 0)) || (y % 400 == 0)) Console.WriteLine("El año " + y + " es biciesto");
    else Console.WriteLine("El año " + y + " NO es biciesto"); */


/* Ejercicio 4 (4)

for(int i=1; i <=100;i++)
{
    if (i % 2 == 0) { Console.WriteLine("El número " + i + " es par."); }
}

*/

// Ejercicio 4 (8)

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




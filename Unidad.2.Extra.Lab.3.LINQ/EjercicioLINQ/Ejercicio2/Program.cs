// See https://aka.ms/new-console-template for more information


/* 
Crear un programa que acepte una lista de números, los almacene en un objeto del tipo List<int>
y luego usando LINQ muestre por Consola aquellos que son mayores a 20 */



int[] lista = { 1, 2, 3, 4, 5, 6, 90, 12, 23, 2, 4, 5, 2, 2, 4345, 53, 43, 4, 2 };

List<int> unaLista = new List<int>();

for (int i = 0; i < lista.Length; i++)
{
    unaLista.Add(lista[i]);
}

var filtrada = from a in unaLista
               where a > 20
               select a;

foreach (var f  in filtrada)
{
    Console.WriteLine(i);
    Console.WriteLine("");
}
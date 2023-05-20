// See https://aka.ms/new-console-template for more information
using clasesLinq;


/* Ejercicio Usando Clase Provincia

Provincia[] provincias = new Provincia[5];

for (int i = 0; i < provincias.Length; i++)
{
    Console.Write("Provincia Numero {0}: ", i+1);
    string n = Console.ReadLine();
    Provincia unaProv = new Provincia(n);
    provincias[i] = unaProv;
} // Realmente no se me ocurre otra forma de poder tener un arreglo con las provincias y usar linq. Por Ahi no es muy eficiente cargar todo.

Console.Clear();

var misProv = from prov in provincias
              where prov.Nombre.StartsWith("T")|prov.Nombre.StartsWith("S")
              select prov;
             
*/


// Ejercicio usando el arreglo normal

string[] provincias = { "Santa Fe", "San Juan", "La Pampa", "Tucuman", "Buenos Aires", "Mendoza", "Catamarca", "Corrientes", "Entre Rios",
                        "San Luis", "Cordoba", "La Rioja", "Tierra del Fuego", "Chubut", "Salta", "Rio Negro", "Neuquen", "Formosa",
                        "Misiones", "Chaco", "Jujuy", "Santa Cruz", "Santiago del Estero"};

var misProv = from prov in provincias
              where prov.StartsWith("T") | prov.StartsWith("S")
              select prov;

foreach (var prov in misProv)
{
    Console.WriteLine(prov);
    Console.WriteLine("");
}




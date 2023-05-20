// See https://aka.ms/new-console-template for more information
using ClasesEj3LINQ;
using System.Collections;



ArrayList listaCiud = new ArrayList();


Ciudad unaCiudad = new Ciudad("Rosario",2000);
Ciudad unaCiudad1 = new Ciudad("Mendoza", 5500);
Ciudad unaCiudad2 = new Ciudad("Ushuaia", 9410);
Ciudad unaCiudad3 = new Ciudad("Bariloche", 1663);
Ciudad unaCiudad4 = new Ciudad("Santa Rosa", 6300);
Ciudad unaCiudad5 = new Ciudad("La Plata", 1900);
Ciudad unaCiudad6 = new Ciudad("Salta", 4400);
Ciudad unaCiudad7 = new Ciudad("Mar del Plata", 7600);
Ciudad unaCiudad8 = new Ciudad("Posadas", 3300);
Ciudad unaCiudad9 = new Ciudad("San Miguel de Tucumán", 4000);


listaCiud.Add(unaCiudad);
listaCiud.Add(unaCiudad1);
listaCiud.Add(unaCiudad2);
listaCiud.Add(unaCiudad3);
listaCiud.Add(unaCiudad4);
listaCiud.Add(unaCiudad5);
listaCiud.Add(unaCiudad6);
listaCiud.Add(unaCiudad7);
listaCiud.Add(unaCiudad8);
listaCiud.Add(unaCiudad9);


var ciu = from Ciudad c in listaCiud
          where c.Nombre.ToLower().Contains("Ros".ToLower().Trim())
          select c;

foreach (var ci in ciu)
{
    Console.WriteLine(ci.CodPostal);
    Console.WriteLine("");
}




















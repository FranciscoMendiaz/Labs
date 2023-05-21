using ClasesEj4LINQ;
using System.Xml.Linq;


/*
Dada una List<Empleado> donde Empleado tiene las propiedades Id (int), Nombre(string),
Sueldo(decimal).Crear un programa que acepte dar de alta Empleados en esta lista y luego
muestre por Consola esta misma Lista ordenada por la propiedad Sueldo, tanto de manera
ascendente como descendente.
*/

List<Empleado> empleados = new List<Empleado>();
int opc = 1;

do
{

    Console.Write("Nombre: ");
    string n = Console.ReadLine();
    Console.Write("Id: ");
    int cod = Int32.Parse(Console.ReadLine());
    Console.Write("Sueldo: ");
    decimal s = Decimal.Parse(Console.ReadLine());
    Empleado empleado = new Empleado(n,cod,s);
    empleados.Add(empleado);
    Console.Clear();
    opc = bandera();

} while (opc != 0);


int bandera()
{
    int op=1;
    
    do {
        Console.WriteLine("Continuar con 1 o SALIR CON 0");
        op = Int32.Parse(Console.ReadLine());
        }while ((op  != 0) && (op !=1));
    
    Console.Clear();
    return op;
}

var filtroMayMen = from e in empleados
             orderby e.Sueldo descending
             select e;

var filtroMenMay = from emp in empleados
                       orderby emp.Sueldo ascending
                       select emp;


Console.Clear();
Console.WriteLine("Lista ordenada de menor a mayor por sueldo");
Console.WriteLine("");

foreach (var emp in filtroMenMay)
{
    Console.WriteLine("Nombre: {0} ; Id: {1} ; Sueldo: {2}",emp.Nombre,emp.Id,emp.Sueldo) ;
    
}
Console.WriteLine("");
Console.WriteLine("Lista ordenada de mayor a menor por sueldo");
Console.WriteLine("");

foreach (var emp in filtroMayMen)
{
    Console.WriteLine("Nombre: {0} ; Id: {1} ; Sueldo: {2}", emp.Nombre, emp.Id, emp.Sueldo);

}
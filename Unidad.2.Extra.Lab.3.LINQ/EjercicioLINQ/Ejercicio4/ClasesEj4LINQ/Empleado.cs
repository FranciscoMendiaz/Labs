namespace ClasesEj4LINQ
{
    public class Empleado
    {
        private int id;
        private string nombre;
        private decimal sueldo;

        public Empleado()
        {
            nombre = string.Empty;
        }

        public Empleado(string name, int cod, decimal salary)
        {
            nombre = name;
            id = cod;
            sueldo = salary;
        }

        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
            }
        }

        public decimal Sueldo
        {
            get => sueldo;
            set
            {
                sueldo = value;
            }
        }
    }
}
namespace ClasePersona
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int dni;

        public Persona()
        {
            this.nombre = "Persona";
            this.apellido = "Sin nombre";
            Console.WriteLine("Se ha creado el objeto persona sin nombre");
        }

        public Persona(string nom, string ape)
        {
            this.nombre = nom;
            this.apellido = ape;
            Console.WriteLine("Se ha creado el objeto persona con nombre {0} y apellido {1}", this.nombre, this.apellido);
        }

        ~Persona()
        {
            Console.WriteLine("Se procederá a destruir el objeto"); 
        }

        public string Apellido
        {
            get => this.apellido;
            set
            {
                apellido = value;
            }
        }

        public string Nombre
        {
            get =>nombre;
            set
            {
                nombre = value;
            }
        }

        public int Dni
        {
            get => dni;
            set
            {
                dni = value;
            }
        }

        public int Edad
        {
            get => edad;
            set
            {
                edad = value;
            }
        }

        public string getFullName()
        {
            return(nombre+apellido);
        }
        
  



    }

}
namespace clasesLinq
{
    public class Provincia
    {
        private string nombre;

        public Provincia()
        {
           nombre = string.Empty;
        }

        public Provincia(string unName)
        {
            nombre = unName;
        }

        public string Nombre
        {
            get =>  nombre;
            set {nombre = value;}
        }
    }
}
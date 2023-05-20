namespace ClasesEj3LINQ
{
    public class Ciudad
    {
        private string nombre;
        private int codPostal;

        public Ciudad()
        {
            nombre = string.Empty;
        }

        public Ciudad(string city, int cod)
        {
            nombre = city;
            codPostal = cod;
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                nombre = value;
            }
        }

        public int CodPostal
        {
            get => codPostal;
            set
            {
                codPostal = value;
            }
        }

    }
}
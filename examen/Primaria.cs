
namespace examen
{
    class Primaria: Iestudiante
    {
        string _nombre = "";
        string _apellido = "";
        string _institucion = "";
        int _id;

        string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        string apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        string institucion
        {
            get { return _institucion; }
            set { _institucion = value; }
        }
        int id
        {
            get { return _id; }
            set { _id = value; }
        }

        public void Datos(string nombre, string apellido, string institucion, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.institucion = institucion;
            this.id = id;
        }

        public int CalculoPrecio()
        {
            return 100;
        }

        public void ImprimirDatos()
        {
            Console.WriteLine("  ");
            Console.WriteLine(" .....Estudiante de Primaria .....");
            Console.WriteLine("Nombre: " +nombre);
            Console.WriteLine("Apellido: " +apellido);
            Console.WriteLine("Nombre de la Institución: " + institucion);
            Console.WriteLine("Cédula de identidad: " + id);
            Console.WriteLine("Valor de la matrícula: " + CalculoPrecio());
        }
    }
}


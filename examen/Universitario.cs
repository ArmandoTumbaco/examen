
namespace examen
{
    class Universitario: Iestudiante
    {
        string _nombre = "";
        string _apellido = "";
        string _institucion = "";
        int _id;
        int _credito;
        int total;
        int precio = 7;
        string nombre
        {
            get {return _nombre;}
            set {_nombre = value;}
        }
        string apellido
        {
            get {return _apellido;}
            set {_apellido = value;}
        }
        string institucion
        {
            get {return _institucion;}
            set {_institucion = value;}
        }
        int id
        {
            get {return _id;}
            set {_id = value;}
        }
        int credito
        {
            get {return _credito;}
            set {_credito = value;}
        }
        public void Datos(string nombre, string apellido, string institucion, int id)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.institucion = institucion;
            this.id = id;
        }
        public void DatosEx(int credito)
        {
            this.credito = credito;
        }
        public int CalculoPrecio()
        {
            total = credito * precio;
            return total;
        }
        public void ImprimirDatos()
        {
            Console.WriteLine("  ");
            Console.WriteLine(" .....Estudiante Universitario .....");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Apellido: " + apellido);
            Console.WriteLine("Nombre de la Institución: " + institucion);
            Console.WriteLine("Cédula de identidad: " + id);
            Console.WriteLine("El valor de la matricula por " + credito + " créditos es de: " + CalculoPrecio() + " $");
        }
    }
}


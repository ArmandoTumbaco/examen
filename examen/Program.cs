namespace examen
{
    class Program
    {
        public static void Main(string[] args)
        {
            Primaria primaria = new Primaria();
            primaria.Datos("Diego Armando", "Tumbaco Arana", "Ramon Virgilio Azua #76", 1350180210);
            primaria.ImprimirDatos();

            Secundaria secundaria = new Secundaria();
            secundaria.Datos("Jose Carlos", "Intriago Rodriguez", "Colegio 5 de junio #76", 1367543211);
            secundaria.DatosExtra(6);
            secundaria.ImprimirDatos();

            Universitario universitario = new Universitario();
            universitario.Datos("Francisco Mateo", "Cedeño Bailon", "ULEAM", 1350325624);
            universitario.DatosEx(4);
            universitario.ImprimirDatos();
        }
    }
}


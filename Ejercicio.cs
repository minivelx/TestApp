namespace TestApp
{
    public abstract class Ejercicio
    {
        public static string enunciado { get; set; }
        public abstract void SolicitarParametros();
        public abstract void ObtenerSolucion();
    }
}

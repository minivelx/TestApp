namespace TestApp.EstructuraDatos.ListaEnlazada
{
    public class Persona
    {
        public Persona()
        {
            nombre = null;
            pFrente = null;
            pEspalda = null;            
        }

        public string nombre { get; set; }        
        public Persona pFrente { get; set; }
        public Persona pEspalda { get; set; }
    }
}

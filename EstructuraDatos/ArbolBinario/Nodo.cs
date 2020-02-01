namespace TestApp.EstructuraDatos.ArbolBinario
{
    public class Nodo
    {
        public Nodo()
        {
            valor = 0;
            nDerecho = null;
            nIzquierdo = null;
        }

        public int valor { get; set; }
        public Nodo nDerecho { get; set; }
        public Nodo nIzquierdo { get; set; }
    }
}

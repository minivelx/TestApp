using System;

namespace TestApp.EstructuraDatos
{
    public class Pila
    {
        public Trasaccion PrimerTrasnaccion { get; set; }

        public Pila()
        {
            PrimerTrasnaccion = null;
        }

        public void InsertarNodo()
        {
            Trasaccion NuevaTrasnaccion = new Trasaccion();
            Console.Write("Ingrese el valor de la venta");
            NuevaTrasnaccion.valor = decimal.Parse(Console.ReadLine());

            NuevaTrasnaccion.tSiguiente = PrimerTrasnaccion;
            PrimerTrasnaccion = NuevaTrasnaccion;
           
        }
    }
}

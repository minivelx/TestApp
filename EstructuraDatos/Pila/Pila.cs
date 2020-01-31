using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.EstructuraDatos
{
    public class Pila
    {
        public Pila()
        {
            cabecera = null;
        }

        public Trasaccion cabecera { get; set; }

        public void AgregarTransaccion()
        {
            Trasaccion nuevaTrasnaccion = new Trasaccion();
            Console.Write("Ingrese el valor de la transacción: $");
            nuevaTrasnaccion.valor = decimal.Parse(Console.ReadLine());

            nuevaTrasnaccion.tAnterior = cabecera;
            cabecera = nuevaTrasnaccion;           
        }

        public void CancelarTransaccion()
        {   
            if(cabecera == null)
                Console.WriteLine("No hay transacciones.");
            else
            {
                var apuntador = cabecera.tAnterior;
                cabecera.tAnterior = null;
                cabecera = apuntador;
                Console.WriteLine("Transacción eliminada correctamente.");                
            }
            Console.ReadLine();
        }

        public void ListarTransacciones()
        {
            if (cabecera == null)
                Console.WriteLine("No hay transacciones para mostrar."); 
            else
                Console.WriteLine(string.Join(" -> ", RecorrerPila()));
            Console.ReadLine();
        }

        public void SumarTransacciones()
        {
            var total = cabecera == null ? 0 : RecorrerPila().Sum(x => x);
            Console.WriteLine(string.Format("Total Ventas: ${0}",total ));
            Console.ReadLine();
        }

        public IEnumerable<decimal> RecorrerPila()
        {
            var apuntador = cabecera;

            while (apuntador != null)
            {
                yield return apuntador.valor;
                apuntador = apuntador.tAnterior;                
            }
        }
    }
}

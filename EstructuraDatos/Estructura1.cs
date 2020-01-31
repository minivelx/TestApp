using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.EstructuraDatos
{
    public class Estructura1 : Ejercicio
    {
        public new static string enunciado = "1. Implemente una Pila que opere de manera LIFO(Last in, first out) para recibir simulación de transacciones de ventas.";
        private int N = 0;

        public override void SolicitarParametros()
        {
            Console.WriteLine("Ingrese el valor de N");
            int.TryParse(Console.ReadLine(), out N);

            if (N < 4)
            {
                Console.Write("Valor Invalido, ");
                SolicitarParametros();
            }
        }

        public override void ObtenerSolucion()
        {
            var result = string.Join(", ", Logica.CalcularMultiplosDe4(N));
            Console.WriteLine(result);
        }
    }
}

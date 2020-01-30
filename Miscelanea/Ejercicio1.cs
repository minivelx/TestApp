using System;

namespace TestApp.Miscelanea
{
    public class Ejercicio1 : Ejercicio
    {              
        public new static string enunciado = "1. Calcular los múltiplos de 4 comprendidos entre 4 y N";
        private int N = 0;

        public override void SolicitarParametros()
        {
            Console.WriteLine("Ingrese el valor de N");
            int.TryParse(Console.ReadLine(), out N);

            if(N < 4)
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

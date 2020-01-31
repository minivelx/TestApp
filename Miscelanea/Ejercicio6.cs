using System;

namespace TestApp.Miscelanea
{
    public class Ejercicio6 : Ejercicio
    {
        public new static string enunciado = "6. Calcular en n-ésimo término de la serie de Fibonacci.";
        private int n = 0;

        public override void SolicitarParametros()
        {
            Console.WriteLine("Ingrese el valor de n");
            int.TryParse(Console.ReadLine(), out n);

            if (n < 3)
            {
                Console.Write("Valor Invalido, ( n >=3 ) ");
                SolicitarParametros();
            }
        }

        public override void ObtenerSolucion()
        {
            var result = Logica.CalcularValorSerieFibonacci(n);
            Console.WriteLine(result);
        }
    }
}

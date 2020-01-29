using System;

namespace TestApp.Miscelanea
{
    public class Ejercicio1 : IEjercicio
    {
        public static readonly string enunciado = "1. Calcular los múltipos de 4 comprendidos entre 4 y N";
        private int N = 0;

        public string ObtenerSolucion()
        {
            var lstResult = Logica.CalcularMultiplosDe4(N);
            var res =  string.Join(", ", Logica.CalcularMultiplosDe4(N));
            Console.WriteLine(res);
            return res;
        }

        public void CargarParametros()
        {
            Console.WriteLine("Ingrese el valor de N");
            N = int.Parse(Console.ReadLine());
        }
    }
}

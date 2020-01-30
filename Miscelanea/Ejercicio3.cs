using System;

namespace TestApp.Miscelanea
{
    public class Ejercicio3 : Ejercicio
    {
        public new static string enunciado = "3. Calcular la suma de los cuadrados de los 100 primeros números naturales.";

        public override void SolicitarParametros()
        {
        }

        public override void ObtenerSolucion()
        {
            var result = Logica.ObtenerSumaCuadrados();
            Console.WriteLine(result);
        }
    }
}

using System;

namespace TestApp.Miscelanea
{
    public class Ejercicio2 : Ejercicio
    {
        public new static string enunciado = "2. Convertir metros a pies y a pulgadas";
        private decimal valor = 0;

        public override void SolicitarParametros()
        {
            Console.Write("Ingrese el valor en metros: ");

            if (!decimal.TryParse(Console.ReadLine(), out valor))
            {
                Console.Write("Valor Invalido, ");
                SolicitarParametros();
            }
        }

        public override void ObtenerSolucion()
        {
            decimal pies = Logica.ConvertirMetrosAPies(valor);
            decimal pulgadas = Logica.ConvertirMetrosAPulgadas(valor);
            Console.WriteLine(string.Format("{0} pies : {1} pulgadas", pies, pulgadas));
        }
    }
}

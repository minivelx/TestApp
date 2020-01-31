using System;

namespace TestApp.Miscelanea
{
    public class Ejercicio5 : Ejercicio
    {
        public new static string enunciado = "5. Calcular: Ex = 1 + x + x^2/2! + x^3/3! + ... + x^n/n! para N > 0";
        private static string enunciadoA = "a) Para N dado.";
        private static string enunciadoB = "b) Hasta que N sea tal que x^n/n < E (por ejemplo, E = 10^-4).";
        private string opc = string.Empty;
        private int N= 0;
        private int x = 0;
        private decimal E =0;

        public override void SolicitarParametros()
        {            
            Console.WriteLine(enunciadoA);
            Console.WriteLine(enunciadoB);
            opc = Console.ReadLine().ToLower();

            if (!(opc == "a" || opc == "b"))
            {
                Console.WriteLine("opción invalida");
                SolicitarParametros();
            }                    
        }

        public override void ObtenerSolucion()
        {
            if (opc.ToLower() == "a")
            {

            }

            if (opc.ToLower() == "b")
            {

            }
        }
    }
}

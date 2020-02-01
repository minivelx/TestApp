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
        private decimal x = 0;
        private decimal E =0;
        private decimal result = 0;

        public override void SolicitarParametros()
        {            
            Console.WriteLine(enunciadoA);
            Console.WriteLine(enunciadoB);
            opc = Console.ReadLine().ToLower();

            if (!(opc == "a" || opc == "b"))
            {
                Console.WriteLine("Opción invalida");
                SolicitarParametros();
            }
            else
                MostrarSubMenu();
        }

        public override void ObtenerSolucion()
        {
            Console.WriteLine(result);
        }

        public  void MostrarSubMenu()
        {
            if (opc.ToLower() == "a")
                OpcionA();

            if (opc.ToLower() == "b")
                OpcionB();
        }

        private void OpcionA()
        {
            Console.Write("Ingrese el valor de N: ");
            int.TryParse(Console.ReadLine(), out N);
            Console.Write("Ingrese el valor de X: ");
            string sX = Console.ReadLine();
            x = Convert.ToDecimal(sX.Replace(".", ","));

            if (N > 0)
            {
                result = Logica.CalcularSerieExponencial(x, N);                
            }
            else
            {
                Console.WriteLine("Valor de N invalido.");
                Console.ReadLine();
                OpcionA();
            }
        }

        private void OpcionB()
        {
            Console.Write("Ingrese el valor de E: ");
            string sE = Console.ReadLine();
            Console.Write("Ingrese el valor de X: ");
            string sX = Console.ReadLine();

            x = Convert.ToDecimal(sX.Replace(".",","));
            E = Convert.ToDecimal(sE.Replace(".", ","));

            if ((E > 0 && E < 1) && (x > 0 && x <= 1))
            {
                result = Logica.CalcularValorN(x, E);
            }
            else
            {
                Console.WriteLine("Valor de E o X invalido. (x> 0 && x <= 1)");
                Console.ReadLine();
                OpcionB();
            }
        }
    }
}

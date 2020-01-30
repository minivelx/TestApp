using System;
using TestApp.Miscelanea;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string opc = string.Empty;

                while (opc != "8")
                {

                    Console.WriteLine(Ejercicio1.enunciado);
                    Console.WriteLine(Ejercicio2.enunciado);
                    Console.WriteLine(Ejercicio3.enunciado);
                    Console.WriteLine(Ejercicio4.enunciado);
                    Console.WriteLine("8. Salir");
                    Console.Write("opción: ");

                    opc = Console.ReadLine();

                    switch (opc)
                    {
                        case "1":
                            EjecutarEjercicio(new Ejercicio1());
                            break;
                        case "2":
                            EjecutarEjercicio(new Ejercicio2());
                            break;
                        case "3":
                            EjecutarEjercicio(new Ejercicio3());
                            break;
                        case "4":
                            EjecutarEjercicio(new Ejercicio4());
                            break;

                        default: break;
                    }
                    Console.Clear();
                }
            }
            catch (Exception exc)
            {
                string ErrorMsg = exc.GetBaseException().InnerException != null ? exc.GetBaseException().InnerException.Message : exc.GetBaseException().Message;
                Console.WriteLine(string.Format("Error! {0}", ErrorMsg));
                Console.ReadLine();
            }
        }

        private static void EjecutarEjercicio(Ejercicio IEjercicio)
        {
            Console.Clear();
            IEjercicio.SolicitarParametros();
            Console.Write("Solución: ");
            IEjercicio.ObtenerSolucion();
            Console.ReadLine();
        }
    }
}

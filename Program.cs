using System;
using TestApp.EstructuraDatos;
using TestApp.EstructuraDatos.ListaEnlazada;
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

                while (opc != "x")
                {
                    Console.WriteLine(Ejercicio1.enunciado);
                    Console.WriteLine(Ejercicio2.enunciado);
                    Console.WriteLine(Ejercicio3.enunciado);
                    Console.WriteLine(Ejercicio4.enunciado);
                    Console.WriteLine(Ejercicio5.enunciado);
                    Console.WriteLine(Ejercicio6.enunciado);
                    Console.WriteLine("7 .Pila");
                    Console.WriteLine("8 .Banco");
                    Console.WriteLine("x. Salir");
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
                        case "5":
                            EjecutarEjercicio(new Ejercicio5());
                            break;
                        case "6":
                            EjecutarEjercicio(new Ejercicio6());
                            break;
                        case "7":
                            Pila();
                            break;
                        case "8":
                            Banco();
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

        private static void Pila()
        {
            string opc = string.Empty;
            var pila = new Pila();

            while (opc != "5")
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar transacción");
                Console.WriteLine("2. Listar Ventas");
                Console.WriteLine("3. Devolver/Cancelar Ultima Venta");
                Console.WriteLine("4. Sumar Valor Ventas");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");

                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        pila.AgregarTransaccion();
                        break;
                    case "2":
                        pila.ListarTransacciones();
                        break;
                    case "3":
                        pila.CancelarTransaccion();
                        break;
                    case "4":
                        pila.SumarTransacciones();
                        break;                                       

                    default: break;
                }
                Console.Clear();
            }
        }

        private static void Banco()
        {
            string opc = string.Empty;
            var cola = new Cola();

            while (opc != "5")
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar Persona a la cola");
                Console.WriteLine("2. Listar Cola");                
                Console.WriteLine("3. Atender Persona");
                Console.WriteLine("4. Colar persona en la fila");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");

                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        cola.AgregarPersonaEnCola();
                        break;
                    case "2":
                        cola.ListarOrdenCola();
                        break;
                    case "3":
                        cola.AtenderPersona();
                        break;
                    case "4":
                        Console.Write("ingrese la posición de la fila en la que se va a colar la persona: ");
                        int n = 0;
                        int.TryParse(Console.ReadLine(), out n);
                        cola.ColarPersona(n);
                        break;

                    default: break;
                }
                Console.Clear();
            }
        }
    }
}

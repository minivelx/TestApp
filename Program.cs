using System;
using TestApp.Agrupacion;
using TestApp.EstructuraDatos;
using TestApp.EstructuraDatos.ArbolBinario;
using TestApp.EstructuraDatos.ListaEnlazada;
using TestApp.Miscelanea;
using TestApp.Postfix;
using TestApp.Token;

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
                    Console.WriteLine("7. Pila de Ventas");
                    Console.WriteLine("8. Cola del Banco");
                    Console.WriteLine("9. Árbol Binario");
                    Console.WriteLine("10. Evaluación del Token");
                    Console.WriteLine("11. Expresión Postfija");
                    Console.WriteLine("12. Agrupación");
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
                        case "9":
                            Arbol();
                            break;
                        case "10":
                            var validador = new ValidadorToken();
                            validador.CargarCadena();
                            break;
                        case "11":
                            var postfix = new CPostfix();
                            postfix.EvaluarExpresion();
                            break;
                        case "12":
                            Agrupacion();
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

        private static void Arbol()
        {
            string opc = string.Empty;
            var arbol = new Arbol();

            while (opc != "4")
            {
                Console.Clear();
                Console.WriteLine("1. Ingresar nodo al árbol binario");
                Console.WriteLine("2. Consultar ramas de un Nodo");
                Console.WriteLine("3. Contar nodos");
                Console.WriteLine("4. Salir");
                Console.Write("Opción: ");

                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        arbol.InsertarNodo();
                        break;
                    case "2":
                        Console.Write("ingrese el valor del nodo: ");
                        int n = 0;
                        int.TryParse(Console.ReadLine(), out n);
                        arbol.ConsultarRamas(n);
                        break;
                    case "3":
                        arbol.ContarNodos();
                        break;

                    default: break;
                }
                Console.Clear();
            }
        }

        private static void Agrupacion()
        {
            string opc = string.Empty;
            var almacen = new Almacen();

            while (opc != "3")
            {
                Console.Clear();
                Console.WriteLine("1. Cargar archivo .json");
                Console.WriteLine("2. Consultar Informe agrupado de ventas");
                Console.WriteLine("3. Salir");
                Console.Write("Opción: ");

                opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        almacen.CargarVentas();
                        break;
                    case "2":
                        almacen.AgruparVentas();
                        break;

                    default: break;
                }
                Console.Clear();
            };
        }
    }
}

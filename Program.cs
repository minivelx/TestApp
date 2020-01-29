using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestApp.Miscelanea;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1 ej1 = new Ejercicio1();
            ej1.MostrarEnunciado();
            ej1.CargarParametros();
            ej1.ObtenerSolucion();
            Console.ReadLine();
        }
    }
}

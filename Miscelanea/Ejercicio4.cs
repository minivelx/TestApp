using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TestApp.Miscelanea
{
    public class Ejercicio4 : Ejercicio
    {
        public new static string enunciado = "4. Leer un archivo que solo contiene números y sumar los números pares y primos.";
        private List<int> lstNumeros { get; set; }

        public override void SolicitarParametros()
        {
            string ruta = Path.Combine(Environment.CurrentDirectory, "Numeros.txt");
            string text = File.ReadAllText(ruta)?.Trim();
            lstNumeros = text.Split(' ').Select(x=> int.Parse(x)).ToList();
        }

        public override void ObtenerSolucion()
        {
            var result = Logica.ObtenerSumaParesYPrimos(lstNumeros);
            Console.WriteLine(result);
        }
    }
}

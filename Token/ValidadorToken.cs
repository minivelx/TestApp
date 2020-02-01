using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TestApp.Token
{
    public class ValidadorToken
    {
        public ValidadorToken()
        {
            cadena = string.Empty;
        }

        public string cadena { get; set; }

        public void CargarCadena()
        {
            Console.WriteLine("Ingrese el texto a evaluar:");
            cadena = Console.ReadLine();
            ProcesarCadena();
        }

        private void ProcesarCadena()
        {
            Regex rgx = new Regex(@"\{([^{}]+)\}");
            MatchCollection matches = rgx.Matches(cadena);
            if (matches.Count == 0)
                Console.WriteLine("No hay coincidencias.");
            else
                Console.WriteLine("Las palabras claves son:");

            foreach (Match item in matches)
            {
                Console.WriteLine(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(item.Value));
            }

            Console.ReadLine();
        }
    }
}

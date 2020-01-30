using System;
using System.Collections.Generic;
using System.Linq;

namespace TestApp.Miscelanea
{
    public class Logica
    {
        //Ejercicio 1
        public static IEnumerable<int> CalcularMultiplosDe4(int N)
        {
            for(int i = 4; i <=N; i+=4 )
            {
                yield return (i);
            }
        }

        //Ejercicio 2
        public static decimal ConvertirMetrosAPies(decimal valor)
        {
            return valor * 3.28M;
        }

        public static decimal ConvertirMetrosAPulgadas(decimal valor)
        {
            return valor * 39.37M;
        }

        //Ejercicio 3
        public static int ObtenerSumaCuadrados()
        {
            IEnumerable<int> cuadrados = Enumerable.Range(1, 100).Select(x => x * x);
            return cuadrados.Sum(x=> x);
        }

        //Ejercicio 4
        public static int ObtenerSumaParesYPrimos(List<int> lstNumeros)
        {
            throw new NotImplementedException();
        }
    }
}

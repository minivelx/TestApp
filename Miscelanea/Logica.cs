﻿using System;
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
            var cuadrados = Enumerable.Range(1, 100).Select(x => x * x);
            return cuadrados.Sum(x=> x);
        }

        //Ejercicio 4
        public static int ObtenerSumaParesYPrimos(List<int> lstNumeros)
        {
            var numeros = lstNumeros.Where(x => x % 2 == 0 || EsPrimo(x));
            return numeros.Sum(x=> x);
        }

        private static bool EsPrimo(int valor)
        {            
            for (int divisor = 2; divisor < valor; divisor ++)
            {
                if (valor % divisor == 0) return false;               
            }
            return valor == 1 ? false : true;
        }

        //Ejercicio 5
        public static decimal CalcularSerieExponencial(decimal x, int n)
        {
            if (n == 0) return 1;
            return (decimal)Math.Pow((double)x,n)/ Factorial(n) + CalcularSerieExponencial(x, n-1);
        }

        public static int CalcularValorN(decimal x, decimal E)
        {
            int n = 1;
            while( Eval(x, n) >= E )
            {
                n++;
            }

            return n;
        }

        private static decimal Eval(decimal x,  int n)
        {
            return (decimal)Math.Pow((double)x, n) / n;
        }

        public static int Factorial(int n)
        {
            if (n == 1 || n == 0) return 1;
            return n * Factorial(n - 1); 
        }

        //Ejercicio 6
        public static int CalcularValorSerieFibonacci(int n)
        {
            if (n == 0 || n == 1) return 1;

            return (CalcularValorSerieFibonacci(n - 1) + CalcularValorSerieFibonacci(n - 2));
        }       
    }
}

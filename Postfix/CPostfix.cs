using System;
using System.Collections;
using System.Collections.Generic;

namespace TestApp.Postfix
{
    public class CPostfix
    {
        public CPostfix()
        {
            stack = new Stack();
            expresion = string.Empty;
        }

        public Stack stack { get; set; }
        public string expresion { get; set; }

        public void EvaluarExpresion()
        {
            string infixExp = "4*2-2/4*67^2";
            expresion = InfixToPostfix(infixExp);

            decimal a, b, r;
            a = b = r = 0;           

            var arrayexpresion = expresion.Split(' ');

            for(int i = 0; i < arrayexpresion.Length; i++)
            {
                var c = arrayexpresion[i];

                decimal numero = 0;

                if (decimal.TryParse(c, out numero))                
                    stack.Push(numero);                
                else
                {
                    b = (decimal) stack.Pop();
                    a = (decimal)stack.Pop();

                    switch(c)
                    {
                        case "+":
                            r = a + b;
                            stack.Push(r);
                            break;
                        case "-":
                            r = a - b;
                            stack.Push(r);
                            break;
                        case "/":
                            r = a / b;
                            stack.Push(r);
                            break;
                        case "*":
                            r = a * b;
                            stack.Push(r);
                            break;
                        case "^":
                            r = (decimal) Math.Pow((double) a, (double) b);
                            stack.Push(r);
                            break;
                    }
                }

            }

            Console.WriteLine(string.Format("Solucón : {0}", r));
            Console.ReadLine();
        }

        public string InfixToPostfix(string infix)
        {
            string result = string.Empty;
            Stack<string> stack = new Stack<string>();

            var arrayExpresion = infix.Replace("+"," + ")
                                      .Replace("-", " - ")
                                      .Replace("*", " * ")
                                      .Replace("/", " / ")
                                      .Replace("^", " ^ ")
                                      .Split(' ');

            for (int i = 0; i < arrayExpresion.Length; ++i)
            {
                var c = arrayExpresion[i];
                int numero = 0;

                if (int.TryParse(c, out numero))
                    result += c + " ";
                else
                {
                    while (stack.Count != 0 && Jerarquia(c[0]) <= Jerarquia(stack.Peek()[0]))
                        result += stack.Pop() + " ";
                    stack.Push(c);
                }
            }

            while (stack.Count != 0)
                result += stack.Pop() + " ";

            return result.Trim();
        }

        public int Jerarquia(char ch)
        {
            if (ch == '+' || ch == '-')
                return 1;
            else if (ch == '*' || ch == '/')
                return 2;
            else if (ch == '^')
                return 3;
            else
                return -1;
        }
    }
}

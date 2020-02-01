using System.Collections;

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
            expresion = "4*2-2/4*67^2";

            int n, a, b, r;
            n = a = b = r = 0;

            char caracter = ' ';

            for(n = 0; n < expresion.Length; n++)
            {
                caracter = expresion[n];

                if(caracter >= '0' && caracter <= '9')
                {
                    stack.Push(int.Parse(caracter.ToString()));
                }
                else
                {
                    b = (int) stack.Pop();
                    a = (int)stack.Pop();

                    switch(caracter)
                    {
                        case '+':
                            r = a + b;
                            stack.Push(r);
                            break;
                        case '-':
                            r = a - b;
                            stack.Push(r);
                            break;
                        case '/':
                            r = a / b;
                            stack.Push(r);
                            break;
                        case '*':
                            r = a * b;
                            stack.Push(r);
                            break;
                    }
                }

            }

            var res = stack.ToString();

        }

    }
}

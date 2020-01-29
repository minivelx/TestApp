using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Miscelanea
{
    public class Logica
    {
        public static List<int> CalcularMultiplosDe4(int N)
        {
            var lstResult = new List<int>();

            for(int i = 4; i <=N; i+=4 )
            {
                lstResult.Add(i);
            }

            return lstResult;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.EstructuraDatos
{
    public class Trasaccion
    {
        public decimal valor { get; set; }
        public Trasaccion tSiguiente { get; set; }
    }
}

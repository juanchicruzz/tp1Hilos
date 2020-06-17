using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Multihilo
{
    class Program
    {
        static void Main(string[] args)
        {
            PruebaHilos1 P = new PruebaHilos1();
            P.procesar();
            P.procesarThreads();

        }

        
        
    }
}

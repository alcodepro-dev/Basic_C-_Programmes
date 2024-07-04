using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_BasicProgram
{
    internal class FibbonacySeries
    {
        public void fibbonacy()
        {
            int a = 0;
            int b = 1;
            int c;

            for (int i = 0; i < 10; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = c;
                b = c;
                c = a;
            }
           
        }

    }
}

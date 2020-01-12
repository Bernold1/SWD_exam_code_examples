using System;
using System.Collections.Generic;
using System.Text;

namespace Future
{
    class Sequential : FMethods
    {
        public int F1(int a)
        {
            return a + 1;
        }

        public int F2(int a)
        {
            return a + 2;
        }

        public int F3(int c)
        {
            return c + 3;
        }

        public int F4(int b, int d)
        {
            return b + d;
        }

        public void run(int a)
        {
            Console.WriteLine("Sequential");
            var b = F1(a);
            var c = F2(a);
            var d = F3(c);
            var f = F4(b, d);
            Console.WriteLine($"returned value: {f}");           
        }

    }
}

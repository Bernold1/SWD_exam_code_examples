using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Future
{
    class Futures : FMethods
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
            Console.WriteLine("Futures");
            var b = F1(a);
            Task<int> futureB = Task.Run(() => F1(a));
            var c = F2(a);
            var d = F3(c);
            var f = F4(futureB.Result, d);
            Console.WriteLine($"returned value: {f}");
        }
    }
}

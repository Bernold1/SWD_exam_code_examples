using System;
using System.Diagnostics;

namespace Future
{
    class Program
    {
        static void Main(string[] args)
        {
            FMethods sequential = new Sequential();
            FMethods future = new Futures();
            Console.WriteLine("write an integer value");
            var a = Console.ReadLine();
            try
            {
                var result = Int32.Parse(a);
                Console.WriteLine($"your value {result}");
                Stopwatch s1 = new Stopwatch();
                s1.Start();
                sequential.run(result);
                s1.Stop();
                Console.WriteLine("Sequential method: {0}", s1.ElapsedTicks);
                Console.WriteLine("");

                s1.Reset();
                s1.Start();
                future.run(result);
                s1.Stop();
                Console.WriteLine("Using Futures: {0}", s1.ElapsedTicks);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine($"Unable to parse '{a}'");
            }
            
            
        }

    }
}

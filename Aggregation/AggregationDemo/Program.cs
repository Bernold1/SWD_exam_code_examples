using System.Collections.Concurrent;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AggregationDemo
{
    class Program
    {
        private const int NSteps = 1000000000;

        static void Main(string[] args)
        {
            Stopwatch s1 = new Stopwatch();
            s1.Start();
            double serialPi = SerialEstimationOfPi();
            s1.Stop();
            System.Console.WriteLine("Serial: {0}", s1.ElapsedMilliseconds);

            s1.Reset();
            s1.Start();
            double naiveParallelPi = NaiveParallelPi();
            s1.Stop();
            System.Console.WriteLine("Naive Parallel: {0}", s1.ElapsedMilliseconds);

            s1.Reset();
            s1.Start();
            double parallelpi = ParallelPi();
            s1.Stop();
            System.Console.WriteLine("Parallel: {0}", s1.ElapsedMilliseconds);

            s1.Reset();
            s1.Start();
            double parallelPartitionerPi = ParallelPartitionerPi();
            s1.Stop();
            System.Console.WriteLine("Parallel with partitioner: {0}", s1.ElapsedMilliseconds);
        }

        static double SerialEstimationOfPi()
        {
            double sum = 0.0;
            double step = 1.0 / (double)NSteps;

            for (int i = 0; i < NSteps; i++)
            {
                double x = (i + 0.5) * step;
                double partial = 4.0 / (1.0 + x * x);
                sum += partial;
            }
            return step * sum;
        }

        static double NaiveParallelPi()
        {
            double sum = 0.0;
            double step = 1.0 / (double)NSteps;
            object obj = new object();
            Parallel.For(0, NSteps, i =>
            {
                double x = (i + 0.5) * step;
                double partial = 4.0 / (1.0 + x * x);
                lock (obj) sum += partial;
            });
            return step * sum;
        }

        static double ParallelPi()
        {
            double sum = 0.0;
            double step = 1.0 / (double)NSteps;
            object obj = new object();
            Parallel.For(0, NSteps,
            () => 0.0,
            (i, state, partial) =>
            {
                double x = (i + 0.5) * step;
                return partial + 4.0 / (1.0 + x * x);
            },
            partial => { lock (obj) sum += partial; });
            return step * sum;
        }

        static double ParallelPartitionerPi()
        {
            double sum = 0.0;
            double step = 1.0 / (double)NSteps;
            object obj = new object();
            Parallel.ForEach(Partitioner.Create(0, NSteps),
            () => 0.0,
            (range, state, partial) =>
            {
                for (int i = range.Item1; i < range.Item2; i++)
                {
                    double x = (i + 0.5) * step;
                    partial += 4.0 / (1.0 + x * x);
                }
                return partial;
            },
            partial => { lock (obj) sum += partial; });


            return step * sum;


        }
    }
}

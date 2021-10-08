using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPart7
{
    class Program
    {
        static void incrementCount1()
        {
            long count = 0;
            for (long i = 0;i<=100000000;i++)
            {
                count++;
            }
            Console.WriteLine("Count:" + count);
        }
        static void incrementCount2()
        {
            long count = 0;
            for (long i = 0; i <= 100000000; i++)
            {
                count++;
            }
            Console.WriteLine("Count:" + count);
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(incrementCount1);
            Thread t2 = new Thread(incrementCount2);

            
            Stopwatch s1 = new Stopwatch();
            Stopwatch s2 = new Stopwatch();

            s1.Start();
            incrementCount1();
            incrementCount2();
            s1.Stop();

            s2.Start();
            t1.Start();
            t2.Start();
            s2.Stop();
            
            t1.Join();
            t2.Join();
            
            Console.WriteLine("Time taken to complete the work in  single threaded Mode: "+ s1.ElapsedMilliseconds);
            Console.WriteLine("Time taken to complete the work in  multi threaded Mode: " + s2.ElapsedMilliseconds);

        }
    }
}

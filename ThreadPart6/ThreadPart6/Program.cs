using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPart6
{
    class Program
    {
        static long count1 = 0, count2 = 0;

        static void incrementCount1()
        {
            while (true)
            {
                count1+=1;
            }
        }

        static void incrementCount2()
        {
            while (true)
            {
                count2+=1;
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(incrementCount1);
            Thread t2 = new Thread(incrementCount2);
            t1.Priority = ThreadPriority.Lowest;
            t2.Priority = ThreadPriority.Highest;

            t1.Start();
            t2.Start();

            Console.WriteLine("The main thread is going to sleep...");
            Thread.Sleep(10000);
            Console.WriteLine("The main thread woke up...");

            t1.Abort();
            t2.Abort();

            t1.Join();
            t2.Join();

            Console.WriteLine("Count1:"+count1);
            Console.WriteLine("Count2:" + count2);

           

        }
    }
}

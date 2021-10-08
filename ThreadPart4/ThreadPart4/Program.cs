using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPart4
{
    class Program
    {
        static void Test1()
        {
            Console.WriteLine("Thread1 is starting");
            for (int i = 0; i <=25; i++)
            {
                Console.WriteLine("Test1:"+i);

            }
            Thread.Sleep(5000);
            Console.WriteLine("Thread1 is existing");
        }
        static void Test2()
        {
            Console.WriteLine("Thread2 is starting");
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("Test2:" + i);

            }
            Console.WriteLine("Thread2 is existing");
        }

        static void Test3()
        {
            Console.WriteLine("Thread3 is starting");
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("Test3:" + i);

            }
            Console.WriteLine("Thread3 is existing");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("The main thread is tarting");
            Thread t1 = new Thread(Test1);
            Thread t2 = new Thread(Test2);
            Thread t3 = new Thread(Test3);
            t1.Start();t2.Start();t3.Start();
            t1.Join(3000);t2.Join();t3.Join();
            Console.WriteLine("The main thread is existing");

            //1.沒有用join前，thread1、2、3和main的執行順序是?
            //2.使用join後，thread1、2、3和main的執行順序是?
            //3.t1.join使用參數後，與沒使用差異在哪?
        }
    }
}

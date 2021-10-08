using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadPart2
{
    class Program
    {
        static void Test1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test1:" + i);
            }
            Console.WriteLine("Thread 1 is existing");
        }
        static void Test2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test2:" + i);
                if (i == 50)
                {
                    Console.WriteLine("Thread 2 is going to sleep");
                    Thread.Sleep(5000);
                    Console.WriteLine("Thread 2 woke up....");
                }
            }
            Console.WriteLine("Thread 2 is existing");
        }
        static void Test3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("Thread 3 is existing");
        }
        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            //Test3();

            Thread T1 = new Thread(Test1);
            Thread T2 = new Thread(Test2);
            Thread T3 = new Thread(Test3);
            T1.Start();
            T2.Start();
            T3.Start();
            Console.WriteLine("Thread main is existing");

        }
    }
   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPart5
{
    class Program
    {
        void Display()
        {
            lock (this) 
            {
                Console.Write("[C sharp is an");
                Thread.Sleep(5000);
                Console.WriteLine(" object orieted language]");
            }
            
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.Display();
            obj.Display();
            obj.Display();
            //Thread t1 = new Thread(obj.Display);
            //Thread t2 = new Thread(obj.Display);
            //Thread t3 = new Thread(obj.Display);
            //t1.Start();t2.Start();t3.Start();
        }

        //1.呈現single thread 的執行結果
        //2.呈現multithrad，沒有lock的執行結果
        //3.呈現multithrad，有lock的執行結果
        //4.用2、3差異來說明lock的用意
    }
}

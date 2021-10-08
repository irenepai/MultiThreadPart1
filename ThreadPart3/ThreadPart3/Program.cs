using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ThreadPart3
{
    class Program
    {
        static void Test()
        {
            for (int i=0;i<=100;i++)
            {
                Console.WriteLine("Test:"+i);
            }
        }

        static void Test1(object Max)
        {
            int num = Convert.ToInt32(Max);
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Test:" + i);
            }
        }

        static void Main(string[] args)
        {

            //1.當這樣的寫的時候，CLR自動宣告ThreadStart並把Test當作參數傳入
            //Thread t = new Thread(Test);
            //2.ThreadStart是一delegate宣告，delegate表示為function point
            //2.1無參數宣告可用ThreadStart()
            //2.2四種宣告ThreadStart 的方法
            
            //ThreadStart obj = new ThreadStart(Test);
            //ThreadStart obj = Test;
            //ThreadStart obj = () => Test();
            //ThreadStart obj = delegate () { Test(); };


            //Thread t = new Thread(obj);
            //t.Start();
            
            //3.有參數的function宣告
            //3.1使用ParameterizeThreadSafe
            //3.2function的參數需宣告Object
            //3.3因為宣告為Object，所以可以傳任何type，在runtime時就會出錯，沒有type safe保證
            ParameterizedThreadStart pobj = new ParameterizedThreadStart(Test1);
            Thread t1 = new Thread(pobj);
            t1.Start(100);
        }
    }
}

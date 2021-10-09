using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print Started");
            Thread thread = new Thread(Print1);
            //Thread thread1 = new Thread(new Program().Print3);
            Thread thread4 = new Thread(() => Print4(30));
            thread.Start();
            thread4.Start();
            //thread1.Start();
            Console.WriteLine("print Ending");
        }
        public static void Print1()
        {
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Print 01 will be printed"+i);
            }
        }
        public static void Print2()
        {
            for(int j=20;j>0; j--)
            {
                Console.WriteLine("Print 02 will be printed"+j);
            }
        }
        public void Print3()
        {
            for (int j = 20; j > 0; j--)
            {
                Console.WriteLine("Print 03 will be printed" + j);
            }
        }
        static void Print4(int count)
        {
            for (int i =0; i < count; i++)
            {
                Console.WriteLine("Print 04 will be printed" + i);
            }
        }
    }
}

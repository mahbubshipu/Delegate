using System;

namespace DELEGATEs
{
    class Program
    {
        public delegate void MyWorkFor(string message);
        static void Main(string[] args)
        {
            MyWorkFor a = Print;
            a += Print2;//a=a+Print2
            a += Print3;
            a("aaa");
            Console.ReadLine();
        }
       

        public static void Print(string item)
        {
            Console.WriteLine(item+"I am from print1");
        }
        public static void Print2(string item2)
        {
            Console.WriteLine(item2 + "I am from print2");
        }
        public static void Print3(string item3)
        {
            Console.WriteLine(item3 + "I am from print3");
        }
    }
}

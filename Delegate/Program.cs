using System;

namespace Delegate
{
    class Program
    {
        public delegate void MyActity(object desiredvalue);
        static void Main(string[] args)
        {
            MyActity a = PrintAfterFile;
            doSomething(5, a);

            
        }
        public static void doSomething(int x,MyActity action)
        {
            action(x);
            
        }
        public static void Print(object item)
        {
            Console.WriteLine(item);
        }
        public static void PrintAfterFile(object item)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(item);
            Console.WriteLine("--------------------------");
            Console.WriteLine("--------------------------");
        }
    }
}

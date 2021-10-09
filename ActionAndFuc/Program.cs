using System;

namespace ActionAndFuc
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Action<object> a = Print;
            
            doSomething(5, a);


        }
        public static void doSomething(int x, Action<object>action)
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

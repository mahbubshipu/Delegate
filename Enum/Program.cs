using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int)OrderStatus.Order);
            Console.WriteLine((int)OrderStatus.OrderComplete);
            Console.WriteLine((int)OrderStatus.Packenging);
            Console.WriteLine((int)OrderStatus.Deveried);
            Console.WriteLine((int)OrderStatus.Received);
        }
    }
}

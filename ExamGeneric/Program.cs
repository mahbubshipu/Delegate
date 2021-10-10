using System;

namespace ExamGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            var item1 = new ProductFactory<ProductOne>().Create();
            Console.WriteLine(item1.Name);

            var item2 = new ProductFactory<ProductTwo>().Create();
            Console.WriteLine(item2.Name);
        }
    }
}

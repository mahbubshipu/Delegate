using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Array
            Console.WriteLine("Simple Array");
            int[] numbers = new int[] { 10, 1, 2, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.WriteLine("{");
            foreach (var i in numbers)
            {
                Console.Write(i +" ");
            }
            Console.WriteLine("}");
            //2D Array
            Console.WriteLine("\n");
            Console.WriteLine("2D Array");
            Console.WriteLine("--------");
            int[,] numbers1 = new int[4, 2]
            {
             {1,2 },
             {3,4 },
             {5,6 },
             {7,8}
            };
            foreach (var i in numbers1)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(numbers1[0, 1]);//output will be 2
            Console.WriteLine("#########");

            //3D Array
            Console.WriteLine("3D Array");
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            Console.WriteLine(array3D[1,0,2]);
            for (int i = 1; i < array3D.Length; i++)
            {
                Console.WriteLine(i);
            }

        }
    }
}

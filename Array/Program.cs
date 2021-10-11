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

            Console.Write("{");
            foreach (var i in numbers)
            {

               
                Console.Write(i + " ");
                if (i != 0)
                    Console.Write(",");
            }
            Console.WriteLine("}");
            //2D Array
            Console.WriteLine("2D Array");
            Console.WriteLine("--------");
            int[,] numbers1 = new int[4, 2]
            {
             {1,2 },
             {3,4 },
             {5,6 },
             {7,8}
            };
            for(int i = 0; i < numbers1.GetLength(0); i++)
            {
                Console.Write("{");
                for(int j=0; j<numbers1.GetLength(1); j++)
                {
                    if (j != 0)
                        Console.Write(",");
                    Console.Write(numbers1[i,j]+" ");
                }
                Console.WriteLine("}");
                //Console.WriteLine();
            }
            
            Console.WriteLine("#########");

            //3D Array
            Console.WriteLine("3D Array");
            int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                 { { 7, 8, 9 }, { 10, 11, 12 } } };
            
            for (int i = 0; i < array3D.GetLength(0); i++)
            {
                //Console.Write("{");
                for(int j = 0; j < array3D.GetLength(1); j++)
                {
                    //if (j != 0)
                    //    Console.Write(",");
                    Console.Write("{");
                    for (int k = 0; k < array3D.GetLength(2); k++)
                    {   
                        if(k!=0)
                        Console.Write(",");
                        Console.Write(array3D[i,j,k]+" ");
                       
                    }
                    Console.WriteLine("}");
                    Console.WriteLine();
                }
                //Console.WriteLine();
            }

            Console.WriteLine("3D ArrayAS");
            int[,,] array3D1 = new int[3, 3, 2] { { { 1, 2}, { 4, 5},{ 4, 5} },
                                 { { 7, 8}, { 10, 11},{ 4, 5} },
                                 { { 7, 8}, { 10, 11},{ 4, 5} } };


            for (int i = 0; i < array3D1.GetLength(0); i++)
            {
                for (int j = 0; j < array3D1.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < array3D1.GetLength(2); k++)
                    {
                        Console.Write(array3D1[i, j, k] + " ");
                    }
                    Console.Write("}");
                    Console.WriteLine();
                    Console.WriteLine();
                }


            }

        }
    }
}

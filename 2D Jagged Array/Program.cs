using System;

namespace _2D_Jagged_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Jagged Array Jagged Array
            int[][] numbers = new int[][]
            {
                new int[]{1,2,3,4,5,6},
                new int[]{5,6,7,89,10},
                new int[]{10,1,12,13,15,7},
                new int[]{10,1,12}

            };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("\nArray :" + (i + 1));
                Console.WriteLine("===============");
                Console.Write("{");
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (j != 0)
                        Console.Write(",");
                    Console.Write(numbers[i][j]+" ");
                }
                Console.Write("}");
            }
            //2D Jagged Array
            int[][,] jaggedArray4 = new int[][,]
            {
                new int[,] { {1,3}, {5,7}},
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };
            for (int i = 0; i < jaggedArray4.Length; i++)
            {
                Console.WriteLine("\nArray :" + (i + 1));
                Console.WriteLine("=========");
                for (int j = 0; j < jaggedArray4[i].GetLength(0); j++)
                {   
                    if(j!=0)
                        Console.Write(",");
                    Console.Write("{ ");
                    for (int k = 0; k < jaggedArray4[i].GetLength(1); k++)
                    {   
                        if(k!=0)
                            Console.Write(",");
                        Console.Write(jaggedArray4[i][j, k] + " ");
                    }
                    Console.Write("} ");
                }
                Console.WriteLine("\n");
            }


            //Shohanur Rahman
            int[][,] jaggedArray5 = new int[][,]
            {
                new int[,] { {1,3}, {5,7} },
                new int[,] { {0,2}, {4,6}, {8,10} },
                new int[,] { {11,22}, {99,88}, {0,9} }
            };

            for (var i = 0; i < jaggedArray5.Length; i++)
            {
                for (var j = 0; j < jaggedArray5[i].GetLength(0); j++)
                {
                    if (j != 0)
                        Console.Write(",");

                    Console.Write("{");
                    for (var k = 0; k < jaggedArray5[i].GetLength(1); k++)
                    {
                        if (k != 0)
                            Console.Write(",");

                        Console.Write(jaggedArray5[i][j, k]);
                    }
                    Console.Write("}");
                }
                Console.WriteLine();
                Console.WriteLine();
            }


        }
    }
}

using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 500;
            int y = 10;

            try
            {
                while (true)
                {
                    x = x / y--;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine($"{x} {y}");
            }
            //int number1 =1000;
            //int number2 = 0;
            //try
            //{
            //    Console.WriteLine(number1 / number2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    Console.WriteLine("Md. Mahbubul Alom");
            //}
            //int[] arr = { 10, 20, 30, 40, 50 };
            //for(int i = 0; i <= arr.Length; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine();
        }
    }
}

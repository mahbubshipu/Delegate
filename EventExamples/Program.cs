using System;

namespace EventExamples
{
    class Program
    {
        public delegate void MyDelelgate();
        public static event MyDelelgate notification;
        static void Main(string[] args)
        {
            notification += Program_notification;
            notification += Program_notification1;
            notification += Program_notification2;
            notification();
        }

        private static void Program_notification2()
        {
            Console.WriteLine("Savar");
        }

        private static void Program_notification1()
        {
            Console.WriteLine("Mirpur");
        }

        private static void Program_notification()
        {
            Console.WriteLine("Savareeeeeeee");
        }
    }
}

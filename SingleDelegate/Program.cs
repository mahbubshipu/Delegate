using System;

namespace SingleDelegate
{
    class Program
    {
        public delegate int CalculationActivity(int firstNumber, int secondNumber);
        static void Main(string[] args)
        {
            Student student = new Student();

            CalculationActivity calculationActivity = Add;
            InvokeDelegate(calculationActivity,50,45);
            CalculationActivity calculationActivity1 = Sub;
            InvokeDelegate(calculationActivity1,50,45);
            //Console.WriteLine(result);

        }
        public static int Add(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
        public static int Sub(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static void InvokeDelegate(CalculationActivity calculationActivity, int Fnumber, int SNumber)
        {
            int result = calculationActivity(Fnumber, SNumber);
            Console.WriteLine(result);
        }
    }
}

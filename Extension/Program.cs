using System;


namespace Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = DateTime.Now;
            string formation = dateTime.GetFormatTime('#');
            Console.WriteLine(formation);

        }
    }
}

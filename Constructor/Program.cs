using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bottle bottle = new Bottle("Red",3500);
            //Console.WriteLine($"{ bottle.Color}, {bottle.Height}");
            //Student student3 = new Student();
            Student student = new Student("Umma", "Ajmery","Jerin");
            Student student2 = new Student("Umma","Jerin");
            string name = student.GetName();
            string name2 = student2.GetName();
            Console.WriteLine(name);
            Console.WriteLine(name2);
        }
    }
}

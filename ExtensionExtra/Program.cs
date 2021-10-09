using System;

namespace ExtensionExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.ID = 102;
            person.Name = "Mahbub";
            person.Address = "Kushtia";
            string r=person.GetName();
            Console.WriteLine(r);

            DateTime dateTime =DateTime.Now;
            string r1= dateTime.GetFormatType('#');
            Console.WriteLine(r1);
        }
    }
}

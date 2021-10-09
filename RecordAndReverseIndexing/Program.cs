using System;

namespace RecordAndReverseIndexing
{
    class Program
    {
        public record Person(string FirstName, string LastName, string[] PhoneNumbers);
        static void Main(string[] args)
        {
            int[] ages = new int[] { 20, 30, 40, 50, 60 };
            Console.WriteLine(ages[^1]);
            Console.WriteLine(ages[^2]);
            Console.WriteLine(ages[^5]);

            var phoneNumbers = new string[2];
            Person person1 = new("Mahbub", "Shipu", phoneNumbers);
            Person person2 = new("Mahbub", "Shipu", phoneNumbers);
            Console.WriteLine(person1 == person2); // output: True
        }
    }
}

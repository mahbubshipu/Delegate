using System;
using System.Linq;

namespace LinqExamples
{
    public class Student
    {
        public string Name { get; set; }
        public double CGPA { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {   
            
            Student[] students = new Student[3];
            students[0] = new Student { Name = "Mahbub", CGPA = 3.50 };
            students[1] = new Student { Name = "Jerin", CGPA = 4.50 };
            students[2] = new Student { Name = "Tahsan", CGPA = 1.50 };

            var data=from x in students
                    where x.Name.Contains("ah")
                    orderby x.Name
                    select x;
            var dataL = students.Where(a => a.Name.Contains("ah")).OrderBy(b => b.Name);
            var data2 = (from s in data
                        where s.CGPA > 1.00
                        select s).ToArray();
            var data2L = dataL.Where(c => c.CGPA > 2.00).ToArray();
            foreach(var i in data2)
            {
                Console.WriteLine(i.Name);
            }
            Console.WriteLine("-------------------");

            foreach(var j in data2L)
            {
                Console.WriteLine(j.Name);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>() { 
                new Student() { Name = "Mahbub", Study = "BBA", Subject = "Accounting" },
                new Student() { Name = "Alom", Study = "MBA", Subject = "Finance" },
                new Student() { Name = "Shipu", Study = "CSE", Subject = "Management" }
            };
            //var datas = from x in student
            //            where x.Study.Contains("BA")
            //            orderby x.Name
            //            select x;

            //var list = (from l in datas
            //            where l.Subject.Contains("an")
            //            select l).ToList();
            var datas = student.Where(x => x.Study.Contains("BA")).OrderBy(y => y.Name);
            var list = datas.Where(a => a.Subject.Contains("ce")).ToList();
            foreach(var a in list)
            {
                
                if (a.Name =="Alom")
                {
                    Console.WriteLine("No one Found");

                }
                else
                {
                    Console.WriteLine($"{a.Name} {a.Subject}");
                }
                

            }
            


            //foreach(var data in student)
            //{
            //    Console.WriteLine($"Name: { data.Name} \t Study: {data.Study},\t Subject: { data.Subject}");
            //}
            
        }
    }
}

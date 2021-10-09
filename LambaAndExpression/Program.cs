using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LambaAndExpression
{
    class Program
    {
        //public static int Sum(int a, int b) => a + b;
        //public static void Print(string m) => Console.WriteLine(m);
        static void Main(string[] args)
        {
            //int r = Sum(5, 6);
            //Print(r.ToString());

            //Expression<Func<int, int, int>> expression = (a, b) => a + b;
            //var function = expression.Compile();
            //var result = function(2, 5);
            //Console.WriteLine(result);
            List<Employee> employees = new List<Employee>()
            {
                new Employee{ID=102,Name="Mahbub"},
                new Employee{ID=103, Name="Shipu"}
            };
            Employee employee = employees.Find(x=>x.ID==102);
            Console.WriteLine(employee.ID+ " " +employee.Name);
        }

    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}


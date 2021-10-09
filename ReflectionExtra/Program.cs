using System;
using System.Reflection;

namespace ReflectionExtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            var studentInfo = typeof(Student);
            //string assemble=studentInfo.Assembly.FullName;
            //Console.WriteLine(assemble);
            //var methodInfo=studentInfo.GetMethods();
            //foreach(var method in methodInfo)
            //{
            //    Console.WriteLine(method.ReturnType+ " "+method.Name);
            //}
            var properties = studentInfo.GetProperties(BindingFlags.NonPublic|BindingFlags.Instance|BindingFlags.Public);
            foreach(var i in properties)
            {
                Console.WriteLine(i.Name);
            }

        }
    }
}

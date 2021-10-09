using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string option = Console.ReadLine();
                if (string.IsNullOrEmpty(option))
                    break;
                StartVehicle(option,"Blue");
            }
        }
        static void StartVehicle(string option,string color)
        {
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            foreach(var type in types)
            {
                if (type.BaseType.Name == "Vehicle")
                {
                    if (type.Name == option)
                    {
                        //ConstructorInfo constructor = type.GetConstructor(new Type[0]);//Parameter na thakle
                        ConstructorInfo constructor1 = type.GetConstructor(new Type[] {typeof(string) });//Parameter thakle
                        /*object obj = constructor.Invoke(new object[0]);*/////Parameter na thakle
                        object obj = constructor1.Invoke(new object[] { color });

                        MethodInfo memberInfo = type.GetMethod("Start");
                        memberInfo.Invoke(obj, new object[0]);
                    }
                }
            }
        }
    }
}

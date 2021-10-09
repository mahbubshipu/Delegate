using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Bus : Vehicle
    {   
        public Bus(string color)
        {
            Color = color;
        }
        public override void Start()
        {
            Console.WriteLine($"{Color}:Bus Started");
            Console.WriteLine();
        }

        public override void Stop()
        {
            Console.WriteLine("Bus Stopped");
        }
    }
}

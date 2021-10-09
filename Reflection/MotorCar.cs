using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class MotorCar : Vehicle
    {
        public override void Start()
        {
            Console.WriteLine("MotorCar Started");
        }

        public override void Stop()
        {
            Console.WriteLine("MotorCar Stopped");
        }
    }
}

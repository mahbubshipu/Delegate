using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public abstract class Vehicle
    {
        public int SeatCount { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public abstract void Start();
        public abstract void Stop();
    }
}

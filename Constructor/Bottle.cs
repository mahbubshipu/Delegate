using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Bottle
    {
        public string Color { get;private set; }
        public double Height { get;private set; }
        public double Water { get; set; }
        public Bottle(string color, double height)
        {
            Color = color;
            Height = height;
        }

    }
}

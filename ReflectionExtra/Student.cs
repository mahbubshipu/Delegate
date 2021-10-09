using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionExtra
{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public string ReqistrationNumber { get; set; }

        private string PhoneNumber { get; set; }

        public string GetInfo()
        {
            return ID + Name + Address;
        }

    }
}

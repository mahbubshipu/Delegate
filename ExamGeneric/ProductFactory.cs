using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamGeneric
{
    public class ProductFactory<T>where T:class, new ()
    {
        public T Create()
        {
            return new T();
        }
    }
}

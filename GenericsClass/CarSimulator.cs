using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsClass
{
    public class CarSimulator<T>where T:ICar, new ()
    {
        public T _car;

        public CarSimulator()
        {
        }

        public CarSimulator(T car)
        {
            _car = car;

        }
        public T GetCar()
        {
            return new T();
        }
        public bool TestCar()
        {
            try
            {
                _car.start();
                _car.stop();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

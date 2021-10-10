using System;

namespace GenericsClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Point<int> point = new Point<int>();
            point.x = 10;

            Point<string> point1 = new Point<string>();
            point1.Name = "Mahbub";

            Point<double> point2 = new Point<double>();
            point2.Number = 25.00;

            CarSimulator<BMW> carSimulator = new CarSimulator<BMW>(new BMW());
            CarSimulator<Toyota> carSimulator1 = new CarSimulator<Toyota>(new Toyota());

            carSimulator.TestCar();
            carSimulator1.TestCar();


            var item = new CarSimulator<BMW>().TestCar();//
            carSimulator.GetCar();


        }
    }
}

using System;

namespace Events
{
    class Program
    {
        
        public delegate void NotificationMessage(string message);
        public static event NotificationMessage Notification;
        static void Main(string[] args)
        {
            
            Notification += Program_Notification2;
            Notification += Program_Notification3;
            Notification("I love you Jerin");

            Bus bus = new Bus(30);
            bus.EngineStartEvent += Bus_EngineStartEvent; 
            bus.EngineStopEvent += Bus_EngineStopEvent;
            bus.SpeedUpMoveEvent += Bus_SpeedUpMoveEvent; 

            bus.StartEngine();
            bus.StopEngine();
            bus.MoveForward(200);
            bus.MoveForward(100);

            bus.SpeedUpMoveEvent -= Bus_SpeedUpMoveEvent;

            bus.StartEngine();
            bus.StopEngine();
            bus.MoveForward(200);
            bus.MoveForward(100);

        }

        private static void Bus_SpeedUpMoveEvent(int speed)
        {
            Console.WriteLine($"Engine Move:{speed}");
        }

        private static void Bus_EngineStopEvent(int speed)
        {
            Console.WriteLine("Engine Stoped");
        }

        private static void Bus_EngineStartEvent(int speed)
        {
            Console.WriteLine("Engine Started");
        }

        private static void Program_Notification3(string message)
        {
            Console.WriteLine(message);
        }

        private static void Program_Notification2(string message)
        {
            Console.WriteLine(message);
        }

        
    }
}

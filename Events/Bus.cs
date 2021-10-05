using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Bus
    {
        public delegate void EngineActity(int speed);
        public event EngineActity EngineStartEvent;
        public event EngineActity EngineStopEvent;
        public event EngineActity SpeedUpMoveEvent;
        public int SeatCount { get;protected set; }
        public int Speed { get;protected set; }
        public Bus(int seatcount)
        {
            SeatCount = seatcount;
            Speed = 0;
        }
        public void StartEngine()
        {
            Speed = 0;
            if(EngineStartEvent != null)
                EngineStartEvent(Speed);
        }
        public void StopEngine()
        {
            Speed = 0;
            if(EngineStopEvent !=null)
                EngineStopEvent(Speed);
        }
        public void MoveForward(int speed)
        {
            Speed = speed;
            if(SpeedUpMoveEvent!=null)
                SpeedUpMoveEvent(Speed);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace homework2
{
    internal class Program
    {
        public delegate void TickHandler(object sender, TickEventArgs args);
        public class TickEventArgs
        {
            public  string DiDaText { get; set; }
            public TickEventArgs(string diDaText) {  DiDaText = diDaText; }
            public TickEventArgs() { DiDaText = "dida!dida!"; }
        }

        public delegate void AlarmHandler(object sender, AlarmEventArgs args);

        public class AlarmEventArgs
        {
            public string AlarmText { get; set; }
            public AlarmEventArgs(string alarmText) {  AlarmText = alarmText; }
            public AlarmEventArgs() { AlarmText = "Alarm!"; }

        }
        public class Clock
        {
            public event TickHandler Tick;
            public event AlarmHandler Alarm;
            public bool stop=false;
            private int _alarmTime;
            private int _currentTime;
            public void SubscribeEvents()
            {
                Tick += Clock_Tick;
                Alarm += Clock_Alarm;
            }

            private void Clock_Tick(object sender, TickEventArgs args)
            {
                Console.WriteLine(args.DiDaText);
            }

            private void Clock_Alarm(object sender, AlarmEventArgs args)
            {
                Console.WriteLine(args.AlarmText);
            }

            public Clock(int alarmTime) 
            { 
                SubscribeEvents();
                _alarmTime = alarmTime; 
            }
            public void StartClock()
            {
                _currentTime = 0;
                while(!stop)
                {
                    if (_currentTime < _alarmTime)
                    {
                        Thread.Sleep(1000);
                        _currentTime++;
                        OnTick();
                    }
                    OnAlarm();
                }

            }

            private void OnAlarm()
            {
               AlarmEventArgs args = new AlarmEventArgs();
                Alarm.Invoke(this, args);
            }

            private void OnTick()
            {
                TickEventArgs args = new TickEventArgs();
                Tick.Invoke(this, args);
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace homework4
{
    class alarmClock
    {
        public event Action<alarmClock> alarmEvent;
        public event Action<alarmClock> TickEvent;
        public DateTime alarmTime { get; set; }
        public alarmClock(DateTime dateTime)
        {
            alarmTime = dateTime;
        }
        public void run()
        {
            while (true)
            {
                TickEvent(this);
                if (alarmTime == DateTime.Now)
                {
                    alarmEvent(this);
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        public static void Tick(alarmClock sender)
        {
             Console.WriteLine("TickEvent:" +  DateTime.Now.ToString());
        }
        public static void alarm(alarmClock alarmTime)
        {
            Console.WriteLine("AlarmEvent:" + alarmTime.ToString());
        }
        static void Main(string[] args)
        {
            alarmClock clock = new alarmClock(DateTime.Now);
            clock.alarmTime = DateTime.Now.AddSeconds(10);
            clock.TickEvent += Tick;
            clock.alarmEvent+= alarm;
            clock.run();

        }
    }
}

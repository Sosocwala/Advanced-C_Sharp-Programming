using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Event_Handlers
{
    class Program
    {
        class  SetTimeOut
        {
            int _snoozeInMilliSec = 1000;

            public event EventHandler ValueChanged;

            public void startNotification()
            {
                while (_snoozeInMilliSec > 0)
                {
                    Thread.Sleep(_snoozeInMilliSec);
                    ValueChanged?.Invoke(this, new EventArgs())

                    Console.WriteLine("Snooze for (in milli seconds, 0 to terminate): ");
                    _snoozeInMilliSec = int.Parse(Console.ReadLine());
                }
            }
        }
        static void Main(string[] args)
        {
            SetTimeOut obj = new SetTimeOut();
            obj.ValueChanged += EventHandlerMethod;
            obj.startNotification();
            Console.ReadKey();
        }
        static void EventHandlerMethod(object sender, EventArgs e)
        {
            Console.WriteLine("EventHandlerMethod called at " + DateTime.Now.ToString("HH:mm:ss"));
        }   
    }
}

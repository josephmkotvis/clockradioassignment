using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockRadioAssignment
{
    public class ClockRadio
    {
        internal string currentTime = "2:00pm";
        internal string currentStation = "100.7FM";
        internal string currentAlarmTime = "5:00am";
        private bool isAlarmOn;
        public string alarmOnStatus;
        public void DisplayAll()
        {
            ShowTime();
            ShowAlarmStatus();
            ShowAlarmTime();
            ShowCurrentStation();
        }
        public void ShowTime()
        {
            Console.WriteLine("The current time is " + currentTime + ".");
        }
        public void ChangeTime()
        {
            Console.WriteLine("What would you like to change the time to?");
            currentTime = Console.ReadLine();
        }
        public void ShowAlarmStatus()
        {
            if (isAlarmOn == false)
            {
                Console.WriteLine("Your alarm is off");
            }
            else
            {
                Console.WriteLine("Your alarm is on");
            }
        }
        
        public void SetAlarmTime()
        {
            Console.WriteLine("What time would you like to set your alarm for?");
            currentAlarmTime = Console.ReadLine();
        }
        public void FireAlarm()
        {
            Console.WriteLine("ALARM");

        }
        public void ChangeAlarmStatus()
        {
                isAlarmOn = !isAlarmOn;
                string alarmStatus = isAlarmOn ? "on" : "off";
                Console.WriteLine("The alarm has been switched to " + alarmStatus + ".");
        }
        public void SetRadioStation()
        {
            Console.WriteLine("What station would you like?");
            currentStation= Console.ReadLine();
        }
        public void ShowAlarmTime()
        {
            Console.WriteLine("Your alarm time is " + currentAlarmTime + ".");
        }
        public void ShowCurrentStation()
        {
            Console.WriteLine("Your current station is " + currentStation + ".");
        }

    }
}

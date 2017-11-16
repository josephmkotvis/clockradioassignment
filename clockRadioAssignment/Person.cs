using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockRadioAssignment
{
    class Person
    {
        public void DecideToViewOrChange(ClockRadio clockradio)
        {
            Console.WriteLine("Would you like to 'view' or 'change' the clockradio?");
            string decisionToViewOrChange = Console.ReadLine();
            if (decisionToViewOrChange.Equals("view"))
            {
                clockradio.DisplayAll();
                DecideToViewOrChange(clockradio);
            }
            else if (decisionToViewOrChange.Equals("change"))
            {
                MakeDecisionWithClockRadio(clockradio);
            }
            else
            {
                DecideToViewOrChange(clockradio);
            }
        }
        public void MakeDecisionWithClockRadio(ClockRadio clockRadio)
        {
            DecideToChangeTime(clockRadio);
            DecideToTurnOnOffAlarm(clockRadio);
            DecideToChangeAlarm(clockRadio);
            DecideToChangeStation(clockRadio);
            DecideToRedoChoices(clockRadio);
            clockRadio.DisplayAll();
            
        }
        public void DecideToRedoChoices(ClockRadio clockradio)
        {
            Console.WriteLine("Your clockradio is all set! Would you like to redo it? (yes/no)");
            string decisionToRedoChoices = Console.ReadLine();
            if (decisionToRedoChoices.Equals("yes"))
            {
                MakeDecisionWithClockRadio(clockradio);
            }
            else if (decisionToRedoChoices.Equals("no"))
            {
                Console.WriteLine("Your changes are set");
            }
            else
            {
                DecideToRedoChoices(clockradio);
            }
        }
        public void DecideToChangeTime(ClockRadio clockRadio)
        {
            Console.WriteLine("Would you like to change the time? (yes/no)");
            string decisionToChangeTime = Console.ReadLine();
            if (decisionToChangeTime.Equals("yes"))
            {
                clockRadio.ChangeTime();
            }
            else if (decisionToChangeTime.Equals("no"))
            {
                clockRadio.ShowTime();
            }
            else
            {
                DecideToChangeTime(clockRadio); 
            }
        }
        public void DecideToTurnOnOffAlarm(ClockRadio clockRadio)
        {
            clockRadio.ShowAlarmStatus();
            Console.WriteLine("Would you like to change it? (yes/no)");
            string decisionToTurnOnOffAlarm = Console.ReadLine();
            if (decisionToTurnOnOffAlarm.Equals("yes"))
            {
                clockRadio.ChangeAlarmStatus();
            }
            else if (decisionToTurnOnOffAlarm.Equals("no"))
            {
                clockRadio.ShowAlarmStatus();
            }
            else
            {
                DecideToTurnOnOffAlarm(clockRadio);
            }
        }
        public void DecideToChangeAlarm(ClockRadio clockRadio)
        {
            clockRadio.ShowAlarmTime();
            Console.WriteLine(" Would you like to change the alarm time? (yes/no)");
            string decisionToChangeAlarmTime = Console.ReadLine();
            if (decisionToChangeAlarmTime.Equals("yes"))
            {
                clockRadio.SetAlarmTime();
            }
            else if (decisionToChangeAlarmTime.Equals("no"))
            {
                clockRadio.ShowAlarmTime();
            }
            else
            {
                DecideToChangeAlarm(clockRadio);
            }
        }
        public void DecideToChangeStation(ClockRadio clockRadio)
        {
            Console.WriteLine("The current station is " + clockRadio.currentStation + ". Would you like to change the radio station? (yes/no)");
            string decisionToChangeStation = Console.ReadLine();
            if (decisionToChangeStation.Equals("yes"))
            {
                clockRadio.SetRadioStation();
            }
            else if (decisionToChangeStation.Equals("no"))
            {
                clockRadio.ShowCurrentStation();
            }
            else
            {
                DecideToChangeStation(clockRadio);
            }
        }
    }
}

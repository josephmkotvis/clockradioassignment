using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clockRadioAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Joe = new Person();
            ClockRadio Capello = new ClockRadio();
            Joe.DecideToViewOrChange(Capello);
            Console.ReadKey();

        }
    }
}

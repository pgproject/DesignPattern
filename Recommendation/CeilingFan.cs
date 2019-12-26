using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class CeilingFan
    {
        private string _room;

        public CeilingFan(string room)
        {
            this._room = room;
        }

        public void SwitchIn()
        {
            if (_room == "DiningRoom")
                Console.WriteLine("Wentylator jest włączony w jadalni");
            if (_room == "Kitchen")
                Console.WriteLine("Wentylator jest włączony w kuchni");
        }
        public void SwitchOut()
        {
            if (_room == "DiningRoom")
                Console.WriteLine("Wentylator jest wyłączony w jadalni");
            if (_room == "Kitchen")
                Console.WriteLine("Wentylator jest wyłączony w kuchni");
        }
    }
}

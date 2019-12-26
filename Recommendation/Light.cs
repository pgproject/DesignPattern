﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class Light 
    {
        private string _room;

        public Light(string room)
        {
            this._room = room;
        }

        public void SwitchIn()
        {
            if(_room== "DiningRoom")
                Console.WriteLine("Swiatło włączone w jadalni");
            if (_room == "Kitchen")
                Console.WriteLine("Światło włączone w kuchni");
        }
        public void SwitchOut()
        {
            if (_room == "DiningRoom")
                Console.WriteLine("Swiatło jest wyłączone w jadalni");
            if (_room == "Kitchen")
                Console.WriteLine("Światło jest wyłączone w kuchni");
        }
       
    }
}

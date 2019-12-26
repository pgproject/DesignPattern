using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Recommendation
{
    public class StereoSystem
    {
        private string _room;

        public StereoSystem(string room)
        {
            this._room = room;
        }

        public void SwitchIn()
        {
            if (_room == "DiningRoom")
                Console.WriteLine("Wieża stereo jest włączona w jadalni");
            if (_room == "Kitchen")
                Console.WriteLine("Wieża stereo jest włączony w kuchni");
        }
        public void SwitchOut()
        {
            if (_room == "DiningRoom")
                Console.WriteLine("Wieża stereo jest wyłączona w jadalni");
            if (_room == "Kitchen")
                Console.WriteLine("Wieża stereo jest wyłączony w kuchni");
        }
        public void SetCD()
        {
            Debug.WriteLine("asasd");
            Console.Write("Cd jest ustawone. ");
        }
        public void SetDVD()
        {
            Console.WriteLine("DVD jest ustawione, leci sobie film :)");
        }
        public void SetRadio()
        {
            Console.WriteLine("Radio jest ustawione");
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("Głośność jest ustawinona na poziomie: "+volume.ToString());
        }
    }
}

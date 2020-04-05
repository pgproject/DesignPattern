using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.HomeCinema
{
    public class Amplifer
    {
        private Tuner _tuner;
        private CDPlayer _cdPlayer;
        private DVDPlayer _dvdPlayer;

        public void TurnOn()
        {
            Console.WriteLine("Wzmaczniacz włączony");
        }
        public void TurnOff()
        {
            Console.WriteLine("Wzmacniacz wyłączony");
        }
        public void SetCD()
        {
            Console.WriteLine("Ustawiona płyta CD");
        }
        public void SedDvd()
        {
            Console.WriteLine("Ustawiona płyta DVD");
        }
        public void SetStereoSound()
        {
            Console.WriteLine("Ustawiono dzwięk stereo");
        }
        public void SetSpatialSound()
        {
            Console.WriteLine("Ustawiono dzwięk przestrzenny");
        }
        public void SetTuner()
        {
            Console.WriteLine("Ustawiono tuner");
        }
        public void SetVolume(int volumeLevel)
        {
            Console.WriteLine("Ustawiono głośność na poziomie "+volumeLevel);
        }
    }
}

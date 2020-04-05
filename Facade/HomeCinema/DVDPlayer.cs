using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.HomeCinema
{
    public class DVDPlayer
    {
        private Amplifer _amplifier;

        public void TurnOn()
        {
            Console.WriteLine("Włącz DVD");
        }
        public void TurnOff()
        {
            Console.WriteLine("Wyłącz DVD");
        }
        public void EjectDisk()
        {
            Console.WriteLine("Wysuń dysk");
        }
        public void TurnPause()
        {
            Console.WriteLine("Włącz pauze");
        }
        public void SetPlay(string filmName)
        {
            Console.WriteLine("Odtwarzaj film "+filmName);
        }
        public void StepStop()
        {
            Console.WriteLine("Zatrzymaj odtwarzanie");
        }
        public void SetSpatialEfectAudio()
        {
            Console.WriteLine("Ustaw efekt przestrzenny auido");
        }
        public void SetTwoChannelAudio()
        {
            Console.WriteLine("Ustaw dwukanałowe audio");
        }
    }

}

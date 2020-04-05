using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.HomeCinema
{
    public class CDPlayer
    {
        Amplifer _amplifer;
        public void TurnOn()
        {
            Console.WriteLine("Włącz odtwarzcz cd");
        }
        public void TurnOff()
        {
            Console.WriteLine("Wyłącz odtwarzacz CD");
        }
        public void EjectDisk()
        {
            Console.WriteLine("Wysuń dysk");
        }
        public void TurnPause()
        {
            Console.WriteLine("Włącz pauze");
        }
        public void SetPlay()
        {
            Console.WriteLine("Odtwarzaj odtwarzanie");
        }
        public void StepStop()
        {
            Console.WriteLine("Zatrzymaj odtwarzanie");
        }
    }
}

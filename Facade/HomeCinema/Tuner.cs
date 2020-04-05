using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.HomeCinema
{
    public class Tuner
    {
        public void TurnOn()
        {
            Console.WriteLine("Tuner włączony");
        }
        public void TurnOff()
        {
            Console.WriteLine("Tuner wyłączony");
        }
        public void SetRangeFM()
        {
            Console.WriteLine("Ustawiono zakres FM");
        }
        public void SetRangeAm()
        {
            Console.WriteLine("Ustawiono zakres AM");
        }
        public void SetFrequency()
        {
            Console.WriteLine("Ustawiono częstotliwość");
        }
    }
}

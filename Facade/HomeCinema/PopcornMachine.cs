using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.HomeCinema
{
    public class PopcornMachine
    {
        public void TurnOn()
        {
            Console.WriteLine("Maszyna do popcornu włączona");
        }
        public void TurnOff()
        {
            Console.WriteLine("Maszyna do popcornu wyłączona");
        }
        public void PreparePopcorn(float howMuch)
        {
            Console.WriteLine("Przygotuj popcorn w ilości: "+howMuch.ToString()+" gram");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.HomeCinema
{
    public class CInemaLighting
    {
        public void TurnOn()
        {
            Console.WriteLine("Włącz ośweitlenie kinowe");
        }
        public void TurnOff()
        {
            Console.WriteLine("Wyłącz oświetlenie kinowe");
        }
        public void Dimming(int dustLevel)
        {
            Console.WriteLine("Ściemniaj oświetlenie kinowe do poziomu: "+dustLevel);
        }
    }
}

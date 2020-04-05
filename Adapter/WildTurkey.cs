using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WildTurkey:ITurkey
    {
        public void Bubble()
        {
            Console.WriteLine("Gul, gul, gul");
        }

        public void Fly()
        {
            Console.WriteLine("O rany! Latam!... ale latam tylko na krótkich dystansach!");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DontFly : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Nie latam, bo nie umiem latać.");
        }
    }
}

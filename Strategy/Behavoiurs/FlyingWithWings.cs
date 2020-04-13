using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FlyingWithWings : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Latam bo mam skrzydła.");
        }
    }
}

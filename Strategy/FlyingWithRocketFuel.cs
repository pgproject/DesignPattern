using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FlyingWithRocketFuel : IFlying
    {
        public void Fly()
        {
            Console.WriteLine("Uaaa! Lot z napędem rakietowym!");
        }
    }
}

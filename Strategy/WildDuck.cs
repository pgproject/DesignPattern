using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class WildDuck : Duck
    {
        public WildDuck()
        {
            quack = new Quacking();
            flying = new FlyingWithWings();
        }
        public override void View()
        {
            Console.WriteLine("Jestem prawdziwą dziką kaczką.");
        }
    }
}

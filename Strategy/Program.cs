using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck wildDuck = new WildDuck();
            wildDuck.ExecuteQuack();
            wildDuck.ExecuteFly();

            Duck specialDuck = new SpecialDuck();
            specialDuck.ExecuteFly();
            specialDuck.SetFlyingInterface(new FlyingWithRocketFuel());
            specialDuck.ExecuteFly();
            Console.ReadKey();
        }
    }
}

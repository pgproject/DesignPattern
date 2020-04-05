using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WildDuck : IDuck
    {
        public void Fly()
        {
            Console.WriteLine("Kwa, kwa");
        }

        public void Mop()
        {
            Console.WriteLine("O rany! Latam!");
        }
    }
}

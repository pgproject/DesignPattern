using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Expresso : Drink
    {
        public Expresso()
        {
            describe = "Kawa Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}

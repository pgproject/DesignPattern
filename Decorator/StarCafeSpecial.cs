using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class StarCafeSpecial : Drink
    {
        public StarCafeSpecial()
        {
            describe = "Kawa Star Cafe Special";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}

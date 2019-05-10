using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class WhippedCream : ComponentsDecorator
    {
        Drink drink;
        public WhippedCream(Drink drink)
        {
            this.drink = drink;
        }

        public override double Cost()
        {
            return drink.Cost() + 0.3;
        }

        public override string DownloadDescribe()
        {
            return drink.DownloadDescribe() + ", bita śmietana";
        }
    }
}

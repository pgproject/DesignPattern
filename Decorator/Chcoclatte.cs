using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Chcoclatte : ComponentsDecorator
    {
        Drink drink;
        public Chcoclatte(Drink drink)//adandbasdbafda 
        {
            this.drink = drink;
        }

        public override double Cost()
        {
            return drink.Cost() + 0.2;
        }

        public override string DownloadDescribe()
        {
            return drink.DownloadDescribe() + ", czekolada";

        }

   
    }
}

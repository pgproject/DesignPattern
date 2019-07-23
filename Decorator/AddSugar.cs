using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AddSugar:ComponentsDecorator
    {
        Drink _drink;
        public AddSugar(Drink drink) //addadas
        {
           this._drink = drink;
        }

        public override double Cost()
        {
            return _drink.Cost() + 0.1;
        }

        public override string DownloadDescribe()
        {
            return _drink.DownloadDescribe() + ", with brown sugar";
        }
    }
}

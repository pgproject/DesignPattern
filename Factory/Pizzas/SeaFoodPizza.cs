using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzas
{
    public class SeaFoodPizza : Pizza
    {
        private IPizzaIngridientsFactory _iPizzaIngridinetsFactory;

        public SeaFoodPizza(IPizzaIngridientsFactory iPizzaIngridinetsFactory)
        {
            this._iPizzaIngridinetsFactory = iPizzaIngridinetsFactory;
        }

        public override void Preparation()
        {
            Console.WriteLine("Preparation" + Name);
            Crust = _iPizzaIngridinetsFactory.CreateCrust();
            Souce = _iPizzaIngridinetsFactory.CreateSouce();
            Cheasse = _iPizzaIngridinetsFactory.CreateCheasse();
            Clams = _iPizzaIngridinetsFactory.CreateClams();
        }
    }
}

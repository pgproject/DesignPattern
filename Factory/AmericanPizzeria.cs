using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class AmericanPizzeria : Pizzeria
    {
        public override Pizza CreatePizza(string typePizza)
        {

            if (typePizza == "cheasse")
            {
                return new AmericanCheassePizza();
            }
            else return null;
        }
    }
}

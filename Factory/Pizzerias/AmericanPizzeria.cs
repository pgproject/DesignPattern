using Factory.AmericanPizzas;
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
            else if(typePizza=="pepperoni")
            {
                return new AmericanPepperoniPizza();
            }
            else if(typePizza=="vegeterian")
            {
                return new AmericanVegeterianPizza();
            }
            else return null;
        }
    }
}

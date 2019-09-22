using Factory.MexicanPizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Pizzerias
{
    public class MexicianPizzeria : Pizzeria
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType == "cheasse")
            {
                return new MexicanCheassePizza();
            }
            else return null;
        }
    }
}

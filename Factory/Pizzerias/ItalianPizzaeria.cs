using Factory.ItalianPizzas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ItalianPizzaeria : Pizzeria
    {
        public override Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType == "cheasse")
            {
               return new ItalianChassePizza();
            }
            else if (pizzaType == "vegetarian")
            {
               return new ItalianVegeterianPizza();
            }
            else if (pizzaType == "seefood")
            {
                return new ItalianSeaFoodPizza();
            }
            //else if (pizzaType == "peperonni")
            //{
            //    //new ItalianPeperoniPizza();
            //}
            else return null;
        }

    }
}

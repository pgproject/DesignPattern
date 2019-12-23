using Factory.IngridientsFactories;
using Factory.ItalianPizzas;
using Factory.Pizzas;
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
            Pizza pizza = null;
            IPizzaIngridientsFactory iPizzaIngridinetsFactory = new ItalianIngridientsFactory();

            if(pizzaType=="Cheasse")
            {
                pizza = new CheassePizza(iPizzaIngridinetsFactory);
                pizza.SetName("Pizza with cheasse");
            }
            else if (pizzaType == "vegetarian")
            {
                pizza = new VegeterianPizza(iPizzaIngridinetsFactory);
                pizza.SetName("Pizza with vegetables");
            }
            else if (pizzaType == "seefood")
            {
                pizza = new SeaFoodPizza(iPizzaIngridinetsFactory);
                pizza.SetName("Pizza with sea food");
            }
            else if (pizzaType == "peperonni")
            {
                pizza = new PeperonniPizza(iPizzaIngridinetsFactory);
                pizza.SetName("Pizza with peperoinni");
            }
            return pizza;
        }
      
    }
}

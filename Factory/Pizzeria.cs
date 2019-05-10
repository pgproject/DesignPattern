using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Pizzeria
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Preapering();
            pizza.Beaking();
            pizza.Cutting();
            pizza.Packing();

            return pizza;
        }
        public abstract Pizza CreatePizza(string type);
    }
}

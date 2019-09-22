using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.AmericanPizzas
{
    public class AmericanVegeterianPizza: Pizza
    {
        public AmericanVegeterianPizza()
        {
            Name = "American Vegeterian Pizza";
            Crust = "Extra thick, crisp crust";
            Souce = "Souce from plump tomatos";
            Additives.Add("A lot of vegetables");
        }
        new void Cutting()
        {
            Console.WriteLine("Cutting pizza for squere pieces");
        }
    }
}

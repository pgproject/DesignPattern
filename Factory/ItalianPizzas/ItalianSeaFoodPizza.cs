using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.ItalianPizzas
{
    public class ItalianSeaFoodPizza : Pizza
    {
        public ItalianSeaFoodPizza()
        {
            Name = "Italian Sea Food Pizza";
            Crust = "Thin fragile crust";
            Souce = "Souce Marinara";
            Additives.Add("Octopus");
            Additives.Add("Algae");
        }
       
    }
}
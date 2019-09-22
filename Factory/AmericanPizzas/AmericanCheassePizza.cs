using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class AmericanCheassePizza:Pizza
    {
        public AmericanCheassePizza()
        {
            Name = "American Cheasse Pizza";
            Crust = "Extra thick, crisp crust";
            Souce = "Souce from plump tomatos";
            Additives.Add("Thick grated Mozzarella cheasse");
        }

        new void Cutting()
        {
            Console.WriteLine("Cutting pizza for squere pieces");
        }
    }
}

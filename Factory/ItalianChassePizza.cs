using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ItalianChassePizza:Pizza
    {
        public ItalianChassePizza()
        {
            Name = "Italian chasse pizza with Marinara souce";
            Crust = "Thin fragile crust";
            Souce = "Souce Marinara";
            Additives.Add("Grated Regianp cheasse ");
        }

    }
}

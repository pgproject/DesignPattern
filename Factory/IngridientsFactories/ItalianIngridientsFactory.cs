using Factory.Ingridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.IngridientsFactories
{
    public class ItalianIngridientsFactory : IPizzaIngridientsFactory
    {
        public Cheasse CreateCheasse()
        {
            return new ReggianoCheasse();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Crust CreateCrust()
        {
            return new ThinFragileCrust();
        }

        public Peperonni CreatePeperonni()
        {
            return new SlicePepperioni();
        }

        public Souce CreateSouce()
        {
            return new MarinaraSouce();
        }

        public Vegetables[] CreateVegetables()
        {
            Vegetables[] vegetables = { new Garlic(), new Onion(), new Mushrooms(), new RedPepper() };
            return vegetables;
        }
    }
   
}

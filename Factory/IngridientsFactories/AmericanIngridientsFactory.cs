using Factory.Ingridients;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.IngridientsFactories
{
    public class AmericanIngridientsFactory : IPizzaIngridientsFactory
    {
        public Cheasse CreateCheasse()
        {
            return new MozzarellaCheasse();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Crust CreateCrust()
        {
            return new FatFragileCrust();
        }

        public Peperonni CreatePeperonni()
        {
            return new SlicePepperioni();
        }

        public Souce CreateSouce()
        {
            return new TomatoSouce();
        }

        public Vegetables[] CreateVegetables()
        {
            Vegetables[] vegetables = { new Spinach(), new BackOlive(), new Eggplant(), };
            return vegetables;
        }
    }
}

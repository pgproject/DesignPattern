using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public interface IPizzaIngridientsFactory
    {
        Crust CreateCrust();
        Souce CreateSouce();
        Cheasse CreateCheasse();
        Vegetables[] CreateVegetables();
        Peperonni CreatePeperonni();
        Clams CreateClams();
    }
}

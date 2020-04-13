using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempeteMethod
{
    public class Coffe:Drink
    {
        public override void AddedAccessories()
        {
            Console.WriteLine("Dodawanie cukru oraz mleka do smaku");
        }
        public override void Brew()
        {
            Console.WriteLine("Zaparzanie i przsączanie kawy przez filtr");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink drink = new Expresso();
            Console.WriteLine(drink.DownloadDescribe() + drink.Cost() + " zł");

            Drink drink1 = new StarCafeSpecial();
            drink1 = new Chcoclatte(drink1);
            drink1 = new WhippedCream(drink1);
            drink1 = new Chcoclatte(drink1);
            drink1 = new AddSugar(drink1);
            Console.WriteLine(drink1.DownloadDescribe() + " " + drink1.Cost() + " zł");
            Console.ReadKey();
        }
    }
}

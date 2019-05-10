using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzeria american = new AmericanPizzeria();
            Pizzeria italian = new ItalianPizzaeria();

            Pizza pizza = american.OrderPizza("cheasse");
            Console.WriteLine("Eryk ordered: "+pizza.DownloadName());

            pizza = italian.OrderPizza("cheasse");
            Console.WriteLine("John ordered: "+pizza.DownloadName()+"\n");

            Console.ReadKey();
        }
    }
}

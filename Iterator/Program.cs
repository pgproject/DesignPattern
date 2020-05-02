using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            DinnerMenu dinnerMenu = new DinnerMenu();
            AtJackMenu atJackMenu = new AtJackMenu();

            Waitress waitres = new Waitress(pancakeHouseMenu, dinnerMenu, atJackMenu);
            waitres.PrintMenu();
            Console.ReadKey(); 
        }
    }
}

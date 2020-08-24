using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuIngridient panckakeMenu = new Menu("Menu Pancake Hause", "Breakfest");
            MenuIngridient dinerMenu = new Menu("Menu Diner Restaurant", "Lunch");
            MenuIngridient atJackMenu = new Menu("Menu at Jack", "Diner");
            MenuIngridient dessertMenu = new Menu("Menu Dessert Hause", "Dessert");

            MenuIngridient allMenu = new Menu("All Menu", "Connected Menu");
            allMenu.Add(panckakeMenu);
            allMenu.Add(dinerMenu);
            allMenu.Add(atJackMenu);

            dinerMenu.Add(new MenuPosition("Spaghetti", "Makaron spaghetti z sosem marrinara i kromka chleba na zakwasie", true, 3.90));
            
            dinerMenu.Add(dessertMenu);

            dessertMenu.Add(new MenuPosition("Szarlotka", "Szarlotka z lodami waniliowymi", true, 1.59));

            Waitress waitress = new Waitress(allMenu);

            waitress.PrintMenu();
            waitress.PrintAllVegeterianMenu();

            Console.ReadKey();
        }
    }
}

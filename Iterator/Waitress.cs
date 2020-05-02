using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class Waitress
    {
        private IMenu _pancakeHouseMenu;
        private IMenu _dinnerMenu;
        private IMenu _atJackMenu;
        public Waitress(IMenu pancakeHouseMenu, IMenu dinnerMenu, IMenu atJackMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinnerMenu = dinnerMenu;
            this._atJackMenu = atJackMenu;
        }

        public void PrintMenu()
        {
            IIterator pancakeIterator = _pancakeHouseMenu.CreateIterator();
            IIterator dinerIterator = _dinnerMenu.CreateIterator();
            IIterator atJackMenu = _atJackMenu.CreateIterator();
            
            Console.WriteLine("Menu śniadaniowe:");
            _printingMenu(pancakeIterator);
            Console.WriteLine();
            Console.WriteLine("Menu obiadowe");
            _printingMenu(dinerIterator);
            Console.WriteLine();
            Console.WriteLine("Menu lunchowe");
            _printingMenu(atJackMenu);
        }

        private void _printingMenu(IIterator enumerator)
        {
            while(enumerator.HasNext())
            {
                PositionMenu positionMenu = (PositionMenu)enumerator.Current;
                Console.WriteLine(positionMenu.GetName()+ ", ");
                Console.WriteLine(positionMenu.GetPrice()+", ");
                Console.WriteLine(positionMenu.GetDescription());
            }
        }

    }
}

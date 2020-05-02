using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class DinnerMenu:IMenu
    {
        private const int _maximumNumberOfElements = 6;
        private int _numberOfElements = 0;
        private PositionMenu[] _positionsMenu = new PositionMenu[_maximumNumberOfElements];

        public DinnerMenu()
        {
            AddElement("Wegetariańska kanapka BSP.", "(Wegetariańska) Boczek z sałatą i pomidorem, chleb pszenny pełnozairnisty.", true, 2.99);
            AddElement("Kanapka BSP", "Boczek z sałatą i pomidorem, chleb pszenny pełnozairnisty", false, 2.99);
            AddElement("Zupa dnia", "Zupa dnia i sałatka z pomidora", false, 3.29);
            AddElement("Hot-dog", "Hot-dog z kiszoną kapustą, rzodkiewką, cebulą i dodatkiem sera.", false, 3.05);
        }


        public void AddElement(string name, string description, bool vegetarian, double price)
        {
            PositionMenu positionMenu = new PositionMenu(name, description, vegetarian, price);
            if (_numberOfElements >= _maximumNumberOfElements)
            {
                Console.WriteLine("Niestety, menu jest pełne! Nie można dodać nowej pozycji.");
            }
            else
            {
                _positionsMenu[_numberOfElements] = positionMenu;
                _numberOfElements = _numberOfElements + 1;
            }
        }
       
        public IIterator CreateIterator()
        {
            return new DinnerMenuIterator(_positionsMenu);
        }
    }
}

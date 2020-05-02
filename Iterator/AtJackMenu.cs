using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class AtJackMenu:IMenu
    {
        private Dictionary<string, PositionMenu> _positionsMenu = new Dictionary<string, PositionMenu>();

        public AtJackMenu()
        {
            AddElement("Kanapnka wegetariańska z frytkami.", "Kanapka wegetariańska z sałatą i pomodirem.", true, 3.99);
            AddElement("Zupa dnia", "Filiżanka zupy dnia, sałatka.", false, 3.69);
            AddElement("Burito", "Duże burito z łaciatą fasolą, sosem salsa i guacamole (awokado)", true, 4.29);
        }
        public void AddElement(string name, string description, bool vegeterian, double price)
        {
            PositionMenu positionMenu = new PositionMenu(name, description, vegeterian, price);
            _positionsMenu.Add(positionMenu.GetName(), positionMenu);
        }

        public IIterator CreateIterator()
        {
            return new AtJackMenuIterator(_positionsMenu);
        }

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class PancakeHouseMenu:IMenu
    {
        private List<PositionMenu> _positionsMenu=new List<PositionMenu>();
        public PancakeHouseMenu()
        {
            AddElement("Śniadanie neleśnikowe K&B", "Naleśniki z jajecznicą i tostem", true, 2.99);
            AddElement("Śniadanie neleśnikowe zwykłe", "Naleśniki z jajkiem sadzonym i kiełbasą.", false, 2.99);
            AddElement("Naleśniki z jagodami", "Naleśniki ze świeżymi jagodami", true, 3.49);
            AddElement("Wafle nadziewane", "Wafle z jagodami lub truskawkami", true, 3.59);
        }
        public void AddElement(string name, string description,bool vegetarian, double price)
        {
            PositionMenu positionMenu = new PositionMenu(name, description, vegetarian, price);
            _positionsMenu.Add(positionMenu);
        }

        public IIterator CreateIterator()
        {
            return new PancakeHouseMenuIterator(_positionsMenu);
        }
    }
}

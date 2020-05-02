using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class PositionMenu
    {
        private string _name;
        private string _description;
        private bool _vegetarian;
        private double _price;

        public PositionMenu(string name, string description, bool vegetarian, double price)
        {
            _name = name;
            _description = description;
            _vegetarian = vegetarian;
            _price = price; 
        }
        public string GetName()
        {
            return _name;
        }
        public string GetDescription()
        {
            return _description;
        }
        public double GetPrice()
        {
            return _price;
        }
        public bool GetVegetarian()
        {
            return _vegetarian;
        }
    }
}

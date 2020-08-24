using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class MenuPosition:MenuIngridient
    {
        private string _name;
        private string _description;
        private bool _isVegeterian;
        private double _price;

        public MenuPosition(string name, string description, bool isVegeterian, double price)
        {
            _name = name;
            _description = description;
            _isVegeterian = isVegeterian;
            _price = price;
        }

        public override string GetName()
        {
            return _name;
        }
        public override string GetDescription()
        {
            return _description;
        }
        public override double GetPrice()
        {
            return _price;
        }
        public override bool IsVegeterian()
        {
            return _isVegeterian;
        }
        public override void Print()
        {
            Console.WriteLine(" " + GetName());
            if(IsVegeterian())
            {
                Console.WriteLine("(v)");
            }
            Console.WriteLine(", " + GetPrice());
            Console.WriteLine("         --"+GetDescription());
        }
        public override IEnumerator CreateIterator()
        {
            return new EmptyIterator();
        }
    }
}

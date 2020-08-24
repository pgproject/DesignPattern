using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Menu:MenuIngridient
    {
        private ArrayList _menuIngridients = new ArrayList();
        private string _name;
        private string _description;

        public Menu(string name, string description)
        {
            _name = name;
            _description = description;
        }

        public override void Add(MenuIngridient menuIngridient)
        {
            _menuIngridients.Add(menuIngridient);
        }
        public override void Remove(MenuIngridient menuIngridient)
        {
            _menuIngridients.Remove(menuIngridient);
        }
        public override MenuIngridient GetDescendant(int i)
        {
            return (MenuIngridient)_menuIngridients.GetEnumerator(i, _menuIngridients.Count);
        }
        public override string GetName()
        {
            return _name;
        }
        public override string GetDescription()
        {
            return _description;
        }
        public override void Print()
        {
            Console.WriteLine("\n"+GetName());
            Console.WriteLine("\n"+GetDescription());
            Console.WriteLine("-------------------");

            IEnumerator enumerator = _menuIngridients.GetEnumerator();
            while (enumerator.MoveNext())
            {
                MenuIngridient menuIngridient = (MenuIngridient)enumerator.Current;
                menuIngridient.Print();
            }  
        }
        public override IEnumerator CreateIterator()
        {
            return new CompositeIterator(_menuIngridients.GetEnumerator());
        }
    }
}

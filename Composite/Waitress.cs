using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Waitress
    {
        MenuIngridient _allMenu;

        public Waitress(MenuIngridient allMenu)
        {
            _allMenu = allMenu;
        }
        public void PrintMenu()
        {
            _allMenu.Print();
        }
        public void PrintAllVegeterianMenu()
        {
            IEnumerator enumerator = _allMenu.CreateIterator();
            Console.WriteLine("\nMenu Wegetariańskie\n---");
            while (enumerator.MoveNext())
            {
                MenuIngridient menuIngridient = (MenuIngridient)enumerator.Current;
                try
                {
                    if (menuIngridient.IsVegeterian())
                        menuIngridient.Print();
                }
                catch (NotSupportedException e)
                { }
            }
        }
    }
}

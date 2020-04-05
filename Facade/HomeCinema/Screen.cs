using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.HomeCinema
{
    public class Screen
    {
        public void ScreenDown()
        {
            Console.WriteLine("Wysuń ekarn w dół");
        }
        public void ScreenUp()
        {
            Console.WriteLine("Wysuń ekran w górę");
        }
    }
}

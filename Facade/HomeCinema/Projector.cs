using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.HomeCinema
{
    public class Projector
    {
        private DVDPlayer _dvdPlayer;
        public void TurnOn()
        {
            Console.WriteLine("Włącz projektor");
        }
        public void TurnOff()
        {
            Console.WriteLine("Wyłącz projektor");
        }
        public void TVState()
        {
            Console.WriteLine("Włącz tryb tv");
        }
        public void SetWideScreen()
        {
            Console.WriteLine("Włącz tryb szerokoekranowy");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    class Program
    {
        static void Main(string[] args)
        {
            Remote _remote = new Remote();

            Light _light = new Light();
            GarageDoor _garageDoor = new GarageDoor();

            RecomendationSwitchLight _recomendationSwitchLight = new RecomendationSwitchLight(_light);
            _remote.SetRecomendation(_recomendationSwitchLight);
            _remote.ButtonPushed();

            RecomendationOpenGarageDoor _recomendationOpenDoor = new RecomendationOpenGarageDoor(_garageDoor);
            _remote.SetRecomendation(_recomendationOpenDoor);
            _remote.ButtonPushed();

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationOpenGarageDoor : IRecomendation
    {
        private GarageDoor _garageDoor;

        public void Exectue()
        {
            _garageDoor.OpenDoor();
        }

        public void WithDraw()
        {
            _garageDoor.CloseDoor();
        }

        public RecomendationOpenGarageDoor(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
    }
}

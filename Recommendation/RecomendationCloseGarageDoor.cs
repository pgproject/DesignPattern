using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationCloseGarageDoor : IRecomendation
    {
        private GarageDoor _garageDoor;

        public RecomendationCloseGarageDoor(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }

        public void Exectue()
        {
            _garageDoor.CloseDoor();
        }

        public void WithDraw()
        {
            _garageDoor.OpenDoor();
        }
    }
}

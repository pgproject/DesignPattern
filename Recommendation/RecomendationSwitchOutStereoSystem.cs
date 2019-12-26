using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationSwitchOutStereoSystem : IRecomendation
    {
        private StereoSystem _stereoSystem;

        public RecomendationSwitchOutStereoSystem(StereoSystem stereoSystem)
        {
            this._stereoSystem = stereoSystem;
        }

        public void Exectue()
        {
            _stereoSystem.SwitchOut();
        }
    }
}

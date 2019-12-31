using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationSwitchInStereoSystem : IRecomendation
    {
        private StereoSystem _stereoSystem;

        public RecomendationSwitchInStereoSystem(StereoSystem stereoSystem)
        {
            this._stereoSystem = stereoSystem;
        }

        public void Exectue()
        {
            _stereoSystem.SwitchIn();
            _stereoSystem.SetCD();
            _stereoSystem.SetVolume(11);
        }

        public void WithDraw()
        {
            _stereoSystem.SwitchOut();
        }
    }
}

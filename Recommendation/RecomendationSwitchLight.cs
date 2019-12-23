using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationSwitchLight : IRecomendation
    {
        private Light _light;

        public void Exectue()
        {
            _light.SwitchIn();
        }

        public RecomendationSwitchLight(Light light)
        {
            this._light = light;
        }
    }
}

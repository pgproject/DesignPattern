using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationSwitchOutLight : IRecomendation
    {
        private Light _light;

        public RecomendationSwitchOutLight(Light light)
        {
            this._light = light;
        }

        public void Exectue()
        {
            _light.SwitchOut();
        }
    }
}

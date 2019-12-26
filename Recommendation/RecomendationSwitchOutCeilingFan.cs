using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationSwitchOutCeilingFan : IRecomendation
    {
        private CeilingFan _ceilingFan;

        public RecomendationSwitchOutCeilingFan(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }

        public void Exectue()
        {
            _ceilingFan.SwitchOut();
        }
    }
}

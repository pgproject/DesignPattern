using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationSwitchInCellingFan : IRecomendation
    {
        private CeilingFan _celingFan;

        public RecomendationSwitchInCellingFan(CeilingFan celingFan)
        {
            this._celingFan = celingFan;
        }

        public void Exectue()
        {
            _celingFan.SwitchIn();
        }
    }
}

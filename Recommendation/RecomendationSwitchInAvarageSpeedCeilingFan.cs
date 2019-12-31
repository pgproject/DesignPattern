using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationSwitchInAvarageSpeedCeilingFan : IRecomendation
    {

        private CeilingFan _ceilingFan;
        private int _laterSpeed;

        public RecomendationSwitchInAvarageSpeedCeilingFan(CeilingFan celingFan)
        {
            this._ceilingFan = celingFan;
        }

        public void Exectue()
        {
            _ceilingFan.AvarageTurnover();
        }

        public void WithDraw()
        {
            if (_laterSpeed == _ceilingFan.FastSpeed)
            {
                _ceilingFan.HighTurnover();
            }
            else if (_laterSpeed == _ceilingFan.AvarageSpeed)
            {
                _ceilingFan.AvarageTurnover();
            }
            else if (_laterSpeed == _ceilingFan.SlowSpeed)
            {
                _ceilingFan.SlowTurnover();
            }
            else if (_laterSpeed == _ceilingFan.SwitchOut)
            {
                _ceilingFan.Disable();
            }
        }
    }
}


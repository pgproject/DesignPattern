﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class RecomendationSwitchOutCeilingFan : IRecomendation
    {
        private CeilingFan _ceilingFan;
        private int _laterSpeed;

        public RecomendationSwitchOutCeilingFan(CeilingFan ceilingFan)
        {
            this._ceilingFan = ceilingFan;
        }

        public void Exectue()
        {
            _laterSpeed = _ceilingFan.DownloadSpeed();
            _ceilingFan.Disable();
        }

        public void WithDraw()
        {
            if(_laterSpeed==_ceilingFan.FastSpeed)
            {
                _ceilingFan.HighTurnover();
            }
            else if(_laterSpeed==_ceilingFan.AvarageSpeed)
            {
                _ceilingFan.AvarageTurnover();
            }
            else if(_laterSpeed==_ceilingFan.SlowSpeed)
            {
                _ceilingFan.SlowTurnover();
            }
            else if(_laterSpeed==_ceilingFan.SwitchOut)
            {
                _ceilingFan.Disable();
            }
        }
    }
}

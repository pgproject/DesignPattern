using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class SuperRemote
    {
        private IRecomendation[] _recomendationSwitchIn;
        private IRecomendation[] _recomendationSwitchOut;

        public SuperRemote()
        {
            _recomendationSwitchIn = new IRecomendation[12];
            _recomendationSwitchOut = new IRecomendation[12];

            IRecomendation _lackRecomendation = new LackRecomendation();
            for (int i = 0; i < 12; i++)
            {
                _recomendationSwitchIn[i] = _lackRecomendation;
                _recomendationSwitchOut[i] = _lackRecomendation;

            }
        }

        public void SetRecomendation(int slot, IRecomendation recomendationSwitchIn, IRecomendation recomendationSwitchOut)
        {
            _recomendationSwitchIn[slot] = recomendationSwitchIn;
            _recomendationSwitchOut[slot] = recomendationSwitchOut;
        }
            
        public void PushedButtonSwitchIn(int slot)
        {
            _recomendationSwitchIn[slot].Exectue();
        }
        public void PushedButtonSwitchOut(int slot)
        {
            _recomendationSwitchOut[slot].Exectue();
        }

        public String ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("\n-----SuperRemote-----\n");
            for (int i = 0; i < _recomendationSwitchIn.Length; i++)
            {
                stringBuilder.Append("[slot" + i + "]" + _recomendationSwitchIn[i].GetType().ToString() + "   "
                    + _recomendationSwitchOut[i].GetType().ToString() + " \n");
            }
            return stringBuilder.ToString();
        }
    }
}

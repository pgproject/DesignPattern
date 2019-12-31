using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class MakroComand : IRecomendation
    {
        IRecomendation[] _irecomendation;

        public MakroComand(IRecomendation[] irecomendation)
        {
            this._irecomendation = irecomendation;
        }

        public void Exectue()
        {
            for (int i = 0; i < _irecomendation.Length; i++)
            {
                _irecomendation[i].Exectue();
            }
        }

        public void WithDraw()
        {
            for (int i = 0; i < _irecomendation.Length; i++)
            {
                _irecomendation[i].WithDraw();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class Remote
    {
        private IRecomendation _recomendation;

        public Remote() { }
        public void SetRecomendation(IRecomendation recomendation)
        {
            _recomendation = recomendation;
        }
        public void ButtonPushed()
        {
            _recomendation.Exectue();
        }
    }
}

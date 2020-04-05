using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class TurkeyAdapter:IDuck
    {
        private ITurkey _turkey;

        public TurkeyAdapter(ITurkey turkey)
        {
            this._turkey = turkey;
        }
        public void Mop()
        {
            _turkey.Bubble();
        }

        public void Fly()
        {
            for (int i = 0; i < 5; i++)
            {
                _turkey.Fly();
            }
        }
    }
}

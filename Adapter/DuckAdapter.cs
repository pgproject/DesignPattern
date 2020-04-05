using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class DuckAdapter : ITurkey
    {
        private IDuck _duck;

        public DuckAdapter(IDuck duck)
        {
            _duck = duck;
        }

        public void Bubble()
        {
            _duck.Mop();
        }

        public void Fly()
        {
            _duck.Fly();
        }
    }
}

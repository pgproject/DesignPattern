using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class EmptyIterator : IEnumerator
    {
        public object Current
        {
            get
            {
                return false;
            }
        }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset()
        {
            throw new NotSupportedException();
        }
    }
}

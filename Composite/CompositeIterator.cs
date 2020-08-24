using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class CompositeIterator: IEnumerator
    {
        Stack stack = new Stack();

        public CompositeIterator(IEnumerator iterator)
        {
            stack.Push(iterator);
        }
        public object Current
        {
            get
            {
                if (MoveNext())
                {
                    IEnumerator iterator = (IEnumerator)stack.Peek();
                    MenuIngridient menuIngridient = (MenuIngridient)iterator.Current;
                    if (menuIngridient is Menu)
                    {
                        stack.Push(menuIngridient.CreateIterator());
                    }
                    return menuIngridient;
                }
                else return null;
            } 
        }

        public bool MoveNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                IEnumerator iterator = (IEnumerator)stack.Peek();
                if (!iterator.MoveNext())
                {
                    stack.Pop();
                    return MoveNext();
                }
                else return true;
            }
        }
        public void Reset()
        {
            throw new NotSupportedException();
        }
    }
}

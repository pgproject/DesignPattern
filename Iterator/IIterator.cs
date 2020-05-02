using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public interface IIterator
    {
        bool HasNext();
        object Current { get; }
        void Remeve();
    }
}

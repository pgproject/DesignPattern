using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract
{
    public abstract class CitiesAbstractFactory
    {
        public abstract AbstractCity AbstractCity(Type type);
    }
}

using SpecialFactoryAbstract.Cities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract
{
    public class CitiesFactory:CitiesAbstractFactory
    {
        public override AbstractCity AbstractCity(Type type)
        {
            if (type == typeof(Cracow))
                return new Cracow();
            else return null;
        }
    }
}

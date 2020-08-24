using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract.Interfaces
{
    public interface IIndustryCities:IAbstractCitiesPlace
    {
        int Surface { get; }
        int AmountOfFactory { get; }
    }
}

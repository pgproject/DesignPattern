using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract.Interfaces
{
    public interface IAbstractCitiesPlace
    {
        bool PlaceIsVisited();
        void OnStart(int pressButton);
        void ToDo();
    }
}

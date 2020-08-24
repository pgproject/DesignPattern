using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            CitiesMenager citiesMenager = new CitiesMenager();
            citiesMenager.OnStart();

            CitiesList.Instance.AbstractCities[0].CitiesPlaces[1].ToDo();

        }
    }
}

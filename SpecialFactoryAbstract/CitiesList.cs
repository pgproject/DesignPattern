using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract
{
    public sealed class CitiesList
    {
        private CitiesList() { }
        public List<AbstractCity> AbstractCities = new List<AbstractCity>();
        private Type _type;
        private static CitiesList _cities = null;
        public static CitiesList Instance
        {
            get
            {
                if (_cities == null)
                    _cities = new CitiesList();
                return _cities;
            }
        }

        public void AddCities(CitiesAbstractFactory citiesFactory, Type type)
        {
            _type = type;
            AbstractCities.Add(citiesFactory.AbstractCity(_type));
        }
    }
}

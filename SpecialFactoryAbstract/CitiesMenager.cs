using SpecialFactoryAbstract.Cities;
using SpecialFactoryAbstract.Interfaces;
using SpecialFactoryAbstract.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract
{
    public class CitiesMenager
    {
        private CitiesAbstractFactory _citiesAbstractFactory;

        
        public void OnStart()
        {
            _citiesAbstractFactory = new CitiesFactory();
            CitiesList.Instance.AddCities(_citiesAbstractFactory, typeof(Cracow));
            CitiesList.Instance.AbstractCities[0].CreateCities(new List<IAbstractCitiesPlace>() { new WawalCastle() as IHistoricCities, new NewIronWorks() as IIndustryCities });
            CitiesList.Instance.AbstractCities[0].CitiesPlaces[0].OnStart(3);
            CitiesList.Instance.AbstractCities[0].CitiesPlaces[1].OnStart(3);
        }
    }
}

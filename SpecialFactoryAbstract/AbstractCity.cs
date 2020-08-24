using SpecialFactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract
{
    public abstract class AbstractCity
    {
        public string NameCity;
        public string DescriptionCity;
        public int AmountOfPeople;
        public bool HasTrain;
        public string State;
        public bool VisitedAllCtiies;
        public List<IAbstractCitiesPlace> CitiesPlaces = new List<IAbstractCitiesPlace>();
        public void CreateCities(List<IAbstractCitiesPlace>citiesPlaces)
        {
            CitiesPlaces.AddRange(citiesPlaces);
        }
        public abstract void VisitedAllPlace();
    }
}

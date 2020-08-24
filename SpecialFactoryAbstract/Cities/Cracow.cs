using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactoryAbstract.Cities
{
    public class Cracow:AbstractCity
    {
        public Cracow()
        {
            NameCity = "Cracow";
            DescriptionCity = "This is a beatufill city with a lot of place wich you can visit";
            HasTrain = true;
            State = "Lesser Poland";
        }

        public override void VisitedAllPlace()
        {
            for (int i = 0; i < CitiesPlaces.Count; i++)
            {
                if (CitiesPlaces[i].PlaceIsVisited())
                {
                    VisitedAllCtiies = true;
                }
            }
        }
    }
}

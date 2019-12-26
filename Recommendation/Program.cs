using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperRemote _remote = new SuperRemote();

            Light _lightDiningRoom = new Light("DiningRoom");
            Light _lightKitchen = new Light("Kitchen");
            CeilingFan _cellingFanDiningRoom = new CeilingFan("DiningRoom");
            CeilingFan _cellingFanKitchen = new CeilingFan("Kitchen");
            StereoSystem _stereoSystemDiningRoom = new StereoSystem("DiningRoom");
            StereoSystem _stereoSystemKitchen = new StereoSystem("Kitchen");

            GarageDoor _garageDoor = new GarageDoor();

            RecomendationSwitchLight _recomendationSwitchLightDiningRoom = new RecomendationSwitchLight(_lightDiningRoom);
            RecomendationSwitchOutLight _recomendationSwitchOutLightDiningRoom= new RecomendationSwitchOutLight(_lightDiningRoom);
            RecomendationSwitchLight _recomendationSwitchLightKithcen = new RecomendationSwitchLight(_lightKitchen);
            RecomendationSwitchOutLight _recomandationSwitchLightKitchen = new RecomendationSwitchOutLight(_lightKitchen);

            RecomendationOpenGarageDoor _recomendationOpenDoor = new RecomendationOpenGarageDoor(_garageDoor);
            RecomendationCloseGarageDoor _recomendationCloseDoor = new RecomendationCloseGarageDoor(_garageDoor);

            RecomendationSwitchInCellingFan _recomendationCelingFanSwitchInKitchen = new RecomendationSwitchInCellingFan(_cellingFanKitchen);
            RecomendationSwitchOutCeilingFan _recomendationCelingFanSwitchOutKitchen = new RecomendationSwitchOutCeilingFan(_cellingFanKitchen);
            RecomendationSwitchInCellingFan _recomendationCelingFanSwitchInDainingRoom = new RecomendationSwitchInCellingFan(_cellingFanDiningRoom);
            RecomendationSwitchOutCeilingFan _recomendationCelingFanSwitchOutDainingRoom = new RecomendationSwitchOutCeilingFan(_cellingFanDiningRoom);

            RecomendationSwitchInStereoSystem _recemendationStereoSystemSwwitchInKitchen = new RecomendationSwitchInStereoSystem(_stereoSystemKitchen);
            RecomendationSwitchOutStereoSystem _remendationStreoSystemSwitchOutKitchen = new RecomendationSwitchOutStereoSystem(_stereoSystemKitchen);
            RecomendationSwitchInStereoSystem _recemendationStereoSystemSwwitchInDainingRoom = new RecomendationSwitchInStereoSystem(_stereoSystemDiningRoom);
            RecomendationSwitchOutStereoSystem _remendationStreoSystemSwitchOutDainingRoom = new RecomendationSwitchOutStereoSystem(_stereoSystemDiningRoom);

            _remote.SetRecomendation(0, _recomendationSwitchLightDiningRoom, _recomendationSwitchOutLightDiningRoom);
            _remote.SetRecomendation(1, _recomendationSwitchLightKithcen, _recomandationSwitchLightKitchen);
            _remote.SetRecomendation(2, _recomendationOpenDoor, _recomendationCloseDoor);
            _remote.SetRecomendation(3, _recomendationCelingFanSwitchInKitchen, _recomendationCelingFanSwitchOutKitchen);
            _remote.SetRecomendation(4, _recomendationCelingFanSwitchInDainingRoom, _recomendationCelingFanSwitchOutDainingRoom);
            _remote.SetRecomendation(5, _recemendationStereoSystemSwwitchInKitchen, _remendationStreoSystemSwitchOutKitchen);
            _remote.SetRecomendation(6, _recemendationStereoSystemSwwitchInDainingRoom, _remendationStreoSystemSwitchOutDainingRoom);


            _remote.PushedButtonSwitchIn(0);
            _remote.PushedButtonSwitchOut(0);

            _remote.PushedButtonSwitchIn(1);
            _remote.PushedButtonSwitchOut(1);

            _remote.PushedButtonSwitchIn(2);
            _remote.PushedButtonSwitchOut(2);

            _remote.PushedButtonSwitchIn(3);
            _remote.PushedButtonSwitchOut(3);

            _remote.PushedButtonSwitchIn(4);
            _remote.PushedButtonSwitchOut(4);

            _remote.PushedButtonSwitchIn(5);
            _remote.PushedButtonSwitchOut(5);

            _remote.PushedButtonSwitchIn(6);
            _remote.PushedButtonSwitchOut(6);

            Console.ReadKey();
        }
    }
}

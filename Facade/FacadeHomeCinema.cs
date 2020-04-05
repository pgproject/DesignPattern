using Facade.HomeCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class FacadeHomeCinema
    {
        private Amplifer _amplifier;
        private Tuner _tuner;
        private DVDPlayer _dvdPlayer;
        private CDPlayer _cdPlayer;
        private Projector _projector;
        private CInemaLighting _cinemaLighting;
        private Screen _screen;
        private PopcornMachine _popcornMachine;

        public FacadeHomeCinema(Amplifer amplifier, Tuner tuner, DVDPlayer dvdPlayer, CDPlayer cdPlayer,
            Projector projector, CInemaLighting cinemaLighting, Screen screen,
            PopcornMachine popcornMachine)
        {
            _amplifier = amplifier;
            _tuner = tuner;
            _dvdPlayer = dvdPlayer;
            _cdPlayer = cdPlayer;
            _projector = projector;
            _cinemaLighting = cinemaLighting;
            _screen = screen;
            _popcornMachine = popcornMachine;
        }
        public void PlayFilm(float amountOfPopcorn, int dustLevel, int setVolume, string filmName)
        {
            Console.WriteLine("Przygotuj się na seans filmowy...");
            _popcornMachine.TurnOn();
            _popcornMachine.PreparePopcorn(amountOfPopcorn);
            _cinemaLighting.TurnOn();
            _cinemaLighting.Dimming(dustLevel);
            _screen.ScreenDown();
            _projector.TurnOn();
            _projector.SetWideScreen();
            _amplifier.TurnOn();
            _amplifier.SedDvd();
            _amplifier.SetSpatialSound();
            _amplifier.SetVolume(setVolume);
            _dvdPlayer.TurnOn();
            _dvdPlayer.SetPlay(filmName);
            Console.WriteLine();
        }
        public void EndOfFilm()
        {
            Console.WriteLine("Koniec seansu, wyłączam kino domowe...");
            _popcornMachine.TurnOff();
            _cinemaLighting.TurnOff();
            _screen.ScreenUp();
            _projector.TurnOff();
            _amplifier.TurnOff();
            _dvdPlayer.StepStop();
            _dvdPlayer.EjectDisk();
            _dvdPlayer.TurnOff();
            Console.WriteLine();

        }
    }
}

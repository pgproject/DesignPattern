using Facade.HomeCinema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        
        
        
        
        
        
        
        
        static void Main(string[] args)
        {
            Amplifer _amplifier=new Amplifer();
            Tuner _tuner=new Tuner();
            DVDPlayer _dvdPlayer=new DVDPlayer();
            CDPlayer _cdPlayer=new CDPlayer();
            Projector _projector=new Projector();
            CInemaLighting _cinemaLighting=new CInemaLighting();
            Screen _screen=new Screen();
            PopcornMachine _popcornMachine=new PopcornMachine();
            FacadeHomeCinema facadeHomeCinema = new FacadeHomeCinema(_amplifier, _tuner, _dvdPlayer, _cdPlayer, _projector, _cinemaLighting, _screen, _popcornMachine);
            facadeHomeCinema.PlayFilm(100, 5, 5, "Rambo");
            facadeHomeCinema.EndOfFilm();

            Console.ReadKey();
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recommendation
{
    public class CeilingFan
    {
        public int FastSpeed = 3;
        public int AvarageSpeed = 2;
        public int SlowSpeed = 1;
        public int SwitchOut = 0;

        private string _room;
        private int _speed;

        public CeilingFan(string room)
        {
            this._room = room;
            _speed = SwitchOut;
        }
        public void HighTurnover()
        {
            _speed = FastSpeed;
            Console.WriteLine("Wentylator włączony w " + _room + " na wysokich obrotach.");
        }
        public void AvarageTurnover()
        {
            _speed = AvarageSpeed;
            Console.WriteLine("Wentylator włączony w " + _room + " na średnich obrotach.");
        }
        public void SlowTurnover()
        {
            _speed = SlowSpeed;
            Console.WriteLine("Wentylator włączony w " + _room+" na niskich obrotach.");
        }
        public void Disable()
        {
            _speed = SwitchOut;
            Console.WriteLine("Wentylator wyłączony w " + _room);
        }
        public int DownloadSpeed()
        {
            return _speed;
        }
    }
}

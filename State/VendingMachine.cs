using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    public class VendingMachine
    {
        const int _lackOfGum = 0;
        const int _lackOfCoin = 1;
        const int _isCoin = 2;
        const int _gumSold = 3;

        private int _state = _lackOfGum;
        private int _amount = 0;
        public VendingMachine(int amount)
        {
            this._amount = amount;
            if (_amount > 0)
                _state = _lackOfCoin;
        }

        public void PutCion()
        {
            if(_state==_isCoin)
            {
                Console.WriteLine("Nie można włożyć więcej niż jednej monety.");
            }
            else if(_state==_lackOfGum)
            {
                Console.WriteLine("Nie można włożyć monety, gdyż automat jest pusty.");
            }
            else if(_state==_gumSold)
            {
                Console.WriteLine("Proszę czekać na gumę.");
            }
            else if(_state==_lackOfCoin)
            {
                _state = _isCoin;
                Console.WriteLine("Moneta przyjęta.");
            }
        }
        public void ReturnCoin()
        {
            if(_state==_isCoin)
            {
                Console.WriteLine("Moneta zwrócona.");
                _state = _lackOfCoin;
            }
            else if(_state==_lackOfCoin)
            {
                Console.WriteLine("Nie włożyłeś monety.");
            }   
            else if(_state==_gumSold)
            {
                Console.WriteLine("Niestety nie można zwrócić monety po przekręceniu gałki.");
            }
            else if(_state==_lackOfGum)
            {
                Console.WriteLine("Nie włożyłeś monety.");
            }
        }
        public void TwistKnob()
        {
            if (_state == _gumSold)
            {
                Console.WriteLine("Nie dostaniesz gumy tylko dlategom, że przekręciłęś gałkę drugi raz!");
            }
            else if (_state == _lackOfCoin)
            {
                Console.WriteLine("Zanim przekręcisz gałkę, wrzuć monetę.");
            }
            else if (_state == _lackOfGum)
            {
                Console.WriteLine("Przekręciłeś gałkę, ale automat jest pusty.");
            }
            else if (_state == _isCoin)
            {
                Console.WriteLine("Obróciłeś gałkę...");
                _state = _gumSold;
                Issue();
            }
        }
        public void Issue()
        {
            if(_state==_gumSold)
            {
                Console.WriteLine("Guma wydana.");
                _amount--;
                if(_amount==0)
                {
                    Console.WriteLine("Ups, koniec gum!");
                    _state = _lackOfGum;
                }
                else
                {
                    _state = _lackOfCoin;
                }
            }
            else if(_state==_lackOfCoin)
            {
                Console.WriteLine("Najpierw zapłać.");
            }
            else if(_state==_lackOfGum)
            {
                Console.WriteLine("Nie wydano gumy.");
            }
            else if(_state==_isCoin)
            {
                Console.WriteLine("Nie wydano gumy.");
            }
        }
    }
}

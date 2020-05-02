using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class DinnerMenuIterator : IIterator
    {
        private PositionMenu[] _elements;
        private int _position;

        public DinnerMenuIterator(PositionMenu[] elements)
        {
            _elements = elements;
        }

        public object Current
        {
            get
            {
                PositionMenu positionMenu = _elements[_position];
                _position = _position + 1;
                return positionMenu;
            }
        }

        public bool HasNext()
        {
            if (_position >= _elements.Length || _elements[_position] == null)
            {
                return false;
            }
            else return true;
        }

        public void Remeve()
        {
            if(_position<=0)
            {
                throw new InvalidOperationException();
            }
            if(_elements[_position-1]!=null)
            {
                for (int i = _position-1; i < _elements.Length-1; i++)
                {
                    _elements[i] = _elements[i + 1];
                }
                _elements[_elements.Length - 1] = null;
            }
        }

    }
}

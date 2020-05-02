using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Iterator
{
    public class AtJackMenuIterator : IIterator
    {
        private Dictionary<string, PositionMenu> _elements = new Dictionary<string, PositionMenu>();
        private int _position;
        public AtJackMenuIterator(Dictionary<string, PositionMenu> elements)
        {
            _elements = elements;
        }

        public object Current
        {
            get
            {
                PositionMenu positionMenu = _elements.ElementAt(_position).Value;
                _position = _position + 1;
                return positionMenu;
            }
        }

        public bool HasNext()
        {
            if (_position >= _elements.Count||_elements.ElementAt(_position).Value== null)
            {
                return false;
            }
            else return true;
        }

        public void Remeve()
        {
            if (_position <= 0)
            {
                throw new InvalidOperationException();
            }
            if (_elements.ElementAt(_position - 1).Value != null)
            {
                Dictionary<string, PositionMenu> element = new Dictionary<string, PositionMenu>();
                for (int i = _position - 1; i < _elements.Count - 1; i++)
                {
                    var c = _elements.ElementAt(i + 1);
                    element.Add(c.Key, c.Value);
                }
                _elements = element;

                var d = _elements.ElementAt(_elements.Count - 1);
                _elements.Remove(d.Key);
            }
        }
    }
}

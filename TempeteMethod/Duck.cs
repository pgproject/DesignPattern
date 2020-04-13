using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempeteMethod
{
    public class Duck : IComparable
    {
        public string _name;
        public int _weight;

        public Duck(string name, int weight)
        {
            _name = name;
            _weight = weight;
        }
        public string ToStrng()
        {
            return _name + " waży" + _weight;
        }

        public int CompareTo(object obj)
        {
            Duck anotherDuck = (Duck)obj;
            if (this._weight < anotherDuck._weight)
            {
                return -1;
            }
            else if (this._weight == anotherDuck._weight)
                return 0;
            else return 1;
                    }
    }
}

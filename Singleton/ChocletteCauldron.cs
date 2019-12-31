using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ChocletteCauldron
    {
        private bool _empty;
        private bool _boiled;

        private static ChocletteCauldron _instance;
        private static readonly object Instancelock = new object();

        private ChocletteCauldron()
        {
            _empty = true;
            _boiled = false;
        }
        public static ChocletteCauldron Instance()
        {
            if(_instance==null)
            { 
                lock (Instancelock)
                {
                    if (_instance == null)
                    {
                        _instance = new ChocletteCauldron();
                    }
                }
            }
            return _instance;
        }
        public void Fill()
        {
            if(IsEmpty())
            {
                _empty = false;
                _boiled = false;
            }
        }
        public void Empty()
        {
            if(!IsEmpty()&& !IsBoiled())
            {
                _boiled = true;
            }
        }
        public bool IsEmpty()
        {
            return _empty;
        }
        public bool IsBoiled()
        {
            return _boiled;
        }
    }
}

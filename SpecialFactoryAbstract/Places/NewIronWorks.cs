using SpecialFactoryAbstract.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SpecialFactoryAbstract.Places
{
    public class NewIronWorks : IIndustryCities
    {
        int pressButton;
        int howManyPress;
        bool isPress;
        public int Surface => throw new NotImplementedException();

        public int AmountOfFactory => throw new NotImplementedException();

        public void OnStart(int a)
        {
            howManyPress = a;
        }

        public bool PlaceIsVisited()
        {
            return isPress;
        }

        public void ToDo()
        {
            if (Keyboard.IsKeyDown(Key.N))
            {
                pressButton++;
            }
            if (pressButton == howManyPress)
                isPress = true;
            Debug.WriteLine(isPress);
        }
    }
}

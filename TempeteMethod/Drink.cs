using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempeteMethod
{
    public abstract class Drink
    {
       public void RecepitBrew()
       {
            _boilingWater();
            Brew();
            _poorDrinktoTheCup();
            if(CheckClientWantAccessories())
                AddedAccessories();
       }
       public virtual void Brew() { }
        public virtual void AddedAccessories() { }

        private void _boilingWater()
        {
            Console.WriteLine("Gotowanie wody");
        }
        private void _poorDrinktoTheCup()
        {
            Console.WriteLine("Nalewanie napoju do filiżanki");
        }
        public virtual bool CheckClientWantAccessories()
        {
            return true;
        }
    }
}

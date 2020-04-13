using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        protected IFlying Flying;
        protected IQuack Quack;
        public Duck()
        {
                
        }
        public abstract void View();
        public void ExecuteQuack()
        {
            Quack.Quack();
        }
        public void ExecuteFly()
        {
            Flying.Fly();
        }
        public void SetFlyingInterface(IFlying flying)
        {
            Flying = flying;
        }

        public void SetQuackingInterface(IQuack quack)
        {
            Quack = quack;
        }

    }
}

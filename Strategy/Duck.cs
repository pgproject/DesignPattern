using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        protected IFlying flying;
        protected IQuack quack;
        public Duck()
        {
                
        }
        public abstract void View();
        public void ExecuteQuack()
        {
            quack.Quack();
        }
        public void ExecuteFly()
        {
            flying.Fly();
        }
    }
}

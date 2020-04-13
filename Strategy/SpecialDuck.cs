using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class SpecialDuck : Duck
    {
        public SpecialDuck()
        {
            Flying =new DontFly();
            Quack = new Quacking();
        }
        public override void View()
        {
            throw new NotImplementedException();
        }
    }
}

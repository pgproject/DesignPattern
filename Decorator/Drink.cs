using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Drink
    {
        public string describe = "Anomous Drink";
        virtual public String DownloadDescribe()
        {
            return describe;
        }
        public abstract double Cost(); //aaa
    }
}

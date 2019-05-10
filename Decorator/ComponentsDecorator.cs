using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class ComponentsDecorator:Drink
    {
        public abstract override String DownloadDescribe( );
    }
}

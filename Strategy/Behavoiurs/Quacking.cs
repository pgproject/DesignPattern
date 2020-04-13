using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Quacking : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Kwa! Kwa!");
        }

    }
}

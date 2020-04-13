using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class DontQuack : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("<<<CISZA>>>");
        }
    }
}

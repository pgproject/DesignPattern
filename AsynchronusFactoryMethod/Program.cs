using System;
using System.Threading.Tasks;

namespace AsynchronusFactoryMethod
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            Foo asyncFoo = await Foo.CreateAsync();
            
            
        }
    }
}
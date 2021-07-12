using System;

namespace AdapterDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            MyStringBuilder s = "Hello ";
            s += "World";
            Console.WriteLine(s);
        }
    }
}
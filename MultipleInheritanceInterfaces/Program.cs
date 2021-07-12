using System;

namespace MultipleInheritanceInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dragon();
            d.Weight = 11341;
            d.Fly();
            d.Crawl();
        }
    }
}
using System;

namespace FactoryMethodSecondVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = Point.PointFactory.NewPolarPoint(1.0f, Math.PI / 2);
            Console.WriteLine(point);
        }
    }
}
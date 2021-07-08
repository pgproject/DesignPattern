using System;

namespace GenericValueAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var v = new Vector2i(1, 3);
            v[0] = 0;

            var vv = new Vector2i(3, 1);

            var result = v + vv;

            Console.WriteLine(result);

            Vector<float, Dimensions.Three> u = Vector3f.Create(3.5f, 2.2f, 1);
            
        }
    }
}
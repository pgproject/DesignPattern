using System;
using System.Collections.Generic;
using System.Linq;
using MoreLinq;

namespace VectorAdapter
{
    class Program
    {
        private static readonly List<VectorObject> m_vectorObjects = new List<VectorObject>
        {
            new VectorRactangle(1, 1, 10, 10),
            new VectorRactangle(3, 3, 6, 6)
        };

        public static void DrawPoint(Point p)
        {
            Console.Write(".");
        }

        static void Main(string[] args)
        {
           Draw();
           Draw();
        }

        private static void Draw()
        {
            foreach (var vectorObject in m_vectorObjects)
            {
                foreach (var line in vectorObject)
                {
                    var adapter = new LinePointAdapter(line);
                    adapter.ForEach(DrawPoint);
                }
            }
        }
}
}
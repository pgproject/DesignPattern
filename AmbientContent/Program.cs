using System;

namespace AmbientContent
{
    class Program
    {
        static void Main(string[] args)
        {
            var haouse = new Building();

            using (new BuildingContext(3000))
            {
                haouse.Walls.Add(new Wall(new Point(0, 0), new Point(5000, 0)));
                haouse.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));



                using (new BuildingContext(3500))
                {
                    haouse.Walls.Add(new Wall(new Point(0, 0), new Point(6000, 0)));
                    haouse.Walls.Add(new Wall(new Point(0, 0), new Point(0, 4000)));
                }

                haouse.Walls.Add(new Wall(new Point(5000, 0), new Point(5000, 4000)));
            }

            Console.WriteLine(haouse);
        }
    }
}
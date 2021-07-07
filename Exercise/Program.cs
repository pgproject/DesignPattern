using System;

namespace Exercise
{
    
    public interface IPrototype<T>
    {
        T DeepCopy();
    }
      
      
    public class Point : IPrototype<Point>
    {
        public int X, Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Point(Point point)
        {
            X = point.X;
            Y = point.Y;
        }

        public Point DeepCopy()
        {
            return new Point(X, Y);
        }

        public override string ToString()
        {
            return $"{nameof(X)}: {X}, {nameof(Y)}: {Y}";
        }
    }

    public class Line : IPrototype<Line>
    {
        public Point Start, End;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;
        }

        public Line DeepCopy()
        {
            return new Line(Start, End);
        }

        public Line(Line other)
        {
            Start = new Point(other.Start);
            End = new Point(other.End);
        }

        public override string ToString()
        {
            return $"{nameof(Start)}: {Start}, {nameof(End)}: {End}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var firstPoint = new Line(new Point(1, 3), new Point(3, 4));
            var secondPoint = firstPoint.DeepCopy();

            secondPoint.End = new Point(5, 9);
            
            Console.WriteLine(firstPoint);
            Console.WriteLine(secondPoint);
        }
    }
}
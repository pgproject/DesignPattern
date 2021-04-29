using System;

namespace FactoryMethod
{
    public class Point
    {
        private double m_x, m_y;

        public static Point NewCartesianPoint(double x, double y)
        {
            return new Point(x, y);
        }

        public static Point NewPolarPoint(double rho, double theta)
        {
            return new Point(rho * Math.Cos(theta), rho * Math.Sin(theta));
        }

        public override string ToString()
        {
            return $"{nameof(m_x)}: {m_x}, {nameof(m_y)}: {m_y}";
        }

        private Point(double x, double y)
        {
            this.m_x = x;
            this.m_y = y;
        }
    }
}
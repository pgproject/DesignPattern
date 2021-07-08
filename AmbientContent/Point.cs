namespace AmbientContent
{
    public struct Point
    {
        private int m_x, m_y;

        public Point(int mX, int mY)
        {
            m_x = mX;
            m_y = mY;
        }

        public override string ToString()
        {
            return $"{nameof(m_x)}: {m_x}, {nameof(m_y)}: {m_y}";
        }
    }
}
namespace DynamicDecoratorComposition
{
    public class Square : IShape
    {
        private float m_side;

        public Square(float side)
        {
            m_side = side;
        }

        public string AsString() => $"A square with side {m_side}";

    }
}
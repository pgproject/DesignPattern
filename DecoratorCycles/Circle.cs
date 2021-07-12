namespace DecoratorCycles
{
    public sealed class Circle : Shape
    {
        private float m_radius;

        public Circle() : this(0)
        {
            
        }

        public void Resize(float factor)
        {
            m_radius *= factor;
        }
        public Circle(float radius)
        {
            m_radius = radius;
        }

        public override string AsString() => $"A circle of radius {m_radius}";
    }
}
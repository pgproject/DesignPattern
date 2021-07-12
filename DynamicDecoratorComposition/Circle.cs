namespace DynamicDecoratorComposition
{
    public class Circle : IShape
    {
        private float m_radius;

        public Circle(float radius)
        {
            m_radius = radius;
        }

        public void Resize(float factor)
        {
            m_radius *= factor;
        }

        public string AsString() => $"A circle with radius {m_radius}";
    }
}
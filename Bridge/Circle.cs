namespace Bridge
{
    public class Circle : Shape
    {
        private float m_radius;

        public Circle(IRenderer mRenderer, float mRadius) : base(mRenderer)
        {
            m_radius = mRadius;
        }


        public override void Draw()
        {
            m_renderer.RendererCircle(m_radius);
        }

        public override void Resize(float factor)
        {
            m_radius *= factor;
        }
    }
}
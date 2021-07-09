namespace Bridge
{
    public abstract class Shape
    {
        protected IRenderer m_renderer;

        protected Shape(IRenderer mRenderer)
        {
            m_renderer = mRenderer;
        }

        public abstract void Draw();
        public abstract void Resize(float factor);

    }
    
}
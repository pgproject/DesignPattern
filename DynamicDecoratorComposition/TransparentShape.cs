namespace DynamicDecoratorComposition
{
    public class TransparentShape : IShape
    {
        private IShape m_iShape;
        private float m_transparency;

        public TransparentShape(IShape ishape, float transparency)
        {
            m_iShape = ishape;
            m_transparency = transparency;
        }
        
        public string AsString()
        {
            return $"{m_iShape.AsString()} has {m_transparency * 100.0}% transparency";
        }
    }
}
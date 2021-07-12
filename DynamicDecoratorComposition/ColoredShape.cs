namespace DynamicDecoratorComposition
{
    public class ColoredShape : IShape
    {
        private IShape m_iShape;
        private string m_color;

        public ColoredShape(IShape mIShape, string mColor)
        {
            m_iShape = mIShape;
            m_color = mColor;
        }

        public string AsString() => $"{m_iShape.AsString()} has the color {m_color}";
    }
}
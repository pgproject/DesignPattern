namespace DecoratorCycles
{
    public class ColoredShape : ShapeDecorator<ColoredShape, AbsorbCyclePolicy>
    {
        public ColoredShape(Shape shape) : base(shape)
        {
        }
    }
}
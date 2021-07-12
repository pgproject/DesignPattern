namespace DecoratorCycles
{
    public class Square : Shape
    {
        private float m_sie;

        public Square() : this(0)
        {
            
        }
        public Square(float mSie)
        {
            m_sie = mSie;
        }
        
        public override string AsString() => $"A square of side {m_sie}"; 
    }
}
namespace ExerciseAdapter
{
    public class SquareToRectangleAdapter : IRectangle
    {
        private readonly Square m_square;

        public SquareToRectangleAdapter(Square square)
        {
            m_square = square;
        }

        public int Width => m_square.Side;
        public int Height => m_square.Side;
    }
}
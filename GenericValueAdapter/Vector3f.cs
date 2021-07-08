namespace GenericValueAdapter
{
    public class Vector3f : VectorOfFloat<Dimensions.Three>
    {
        public override string ToString()
        {
            return $"{string.Join(",", m_data)}";
        }
    }
}
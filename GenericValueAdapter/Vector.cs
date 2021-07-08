using System;

namespace GenericValueAdapter
{
    public class Vector<T, D> where D : IInteger, new()
    {
        
        protected T[] m_data;

        public Vector()
        {
            m_data = new T[new D().Value];
        }

        public Vector(params T[] values)
        {
            var requiredSize = new D().Value;
            m_data = new T[requiredSize];

            var providedSize = values.Length;

            for (int i = 0; i < Math.Min(requiredSize, providedSize); i++)
            {
                m_data[i] = values[i];
            }
        }

        public static Vector<T, D> Create(params T[] values)
        {
            return new Vector<T, D>(values);
        }
        
        public T this[int index]
        {
            get => m_data[index];
            set => m_data[index] = value;
        }

        public T X
        {
            get => m_data[0];
            set => m_data[0] = value;
        }
    }
}
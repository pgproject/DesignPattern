using System;

namespace GenericValueAdapter
{
    public class Vector<TSelf, T, D> where D : IInteger, new() where TSelf : Vector<TSelf, T, D>, new()
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

        public static TSelf Create(params T[] values)
        {
            var result = new TSelf();
            
            var requiredSize = new D().Value;
            result.m_data = new T[requiredSize];

            var providedSize = values.Length;

            for (int i = 0; i < Math.Min(requiredSize, providedSize); i++)
            {
                result.m_data[i] = values[i];
            }

            return result;
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
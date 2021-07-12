using System;
using System.Collections.Generic;

namespace DecoratorCycles
{
    public abstract class ShapeDecorator : Shape
    {
        protected internal readonly List<Type> m_types = new();
        protected internal Shape m_shape;

        public ShapeDecorator(Shape shape)
        {
            m_shape = shape;
            if (m_shape is ShapeDecorator sd)
            {
                m_types.AddRange(sd.m_types);                
            }
        }
    }

    public abstract class ShapeDecorator<TSelf, TCyclePolicy> : ShapeDecorator
        where TCyclePolicy : ShapeDecoratorCyclePolicy, new()
    {
        protected ShapeDecorator(Shape shape) : base(shape)
        {
        }
    }
    
}
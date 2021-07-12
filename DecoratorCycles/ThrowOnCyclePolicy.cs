using System;
using System.Collections.Generic;

namespace DecoratorCycles
{
    public class ThrowOnCyclePolicy : ShapeDecoratorCyclePolicy
    {
        private bool m_handler(Type type, IList<Type> allTypes)
        {
            if (allTypes.Contains(type))
                throw new InvalidOperationException(
                    $"Cycle detected! Type is already a {type.FullName}!");
            return true;
        }
        
        
        public override bool TypeAdditionAllowed(Type type, IList<Type> allTypes)
        {
            return m_handler(type, allTypes);
        }

        public override bool ApplicationAllowed(Type type, IList<Type> allTypes)
        {
            return m_handler(type, allTypes);
        }
    }
}
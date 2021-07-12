using System.Linq;

namespace CompositeSpecification
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(params Specification<T>[] items) : base(items)
        {
        }

        public override bool IsSatisfied(T t)
        {
            return m_items.All(i => i.IsSatisfied(t));
        }
    }
}
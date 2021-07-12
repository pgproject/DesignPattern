namespace CompositeSpecification
{
    public abstract class CompositeSpecification<T> : Specification<T>
    {
        protected readonly Specification<T>[] m_items;
        
        public CompositeSpecification(params Specification<T> [] items)
        {
            this.m_items = items;
        }
    }
}
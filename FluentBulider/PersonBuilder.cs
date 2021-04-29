namespace FluentBulider
{
    public abstract class PersonBuilder
    {
        protected Person m_person = new Person();

        public Person Build()
        {
            return m_person;
        }
        
    }
}
namespace FasetedBuilder
{
    public class PersonBuilder
    {
        protected Person m_person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(m_person);

        public PersonAddressBuilder Lives => new PersonAddressBuilder(m_person);

        public static implicit operator Person(PersonBuilder personBuilder)
        {
            return personBuilder.m_person;
        }
    }
}
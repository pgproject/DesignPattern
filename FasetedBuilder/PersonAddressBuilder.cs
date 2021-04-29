namespace FasetedBuilder
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.m_person = person;
        }

        public PersonAddressBuilder In(string city)
        {
            m_person.City = city;
            return this;
        }

        public PersonAddressBuilder At(string streetAddresses)
        {
            m_person.StreetAddress = streetAddresses;
            return this;
        }

        public PersonAddressBuilder WithPostCode(string postCode)
        {
            m_person.Postcode = postCode;
            return this;
        }
    
    }
}
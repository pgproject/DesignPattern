namespace FasetedBuilder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.m_person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            m_person.CompanyName = companyName;
            return this;
        }

        public PersonJobBuilder AsA(string position)
        {
            m_person.Position = position;
            return this;
        }

        public PersonJobBuilder Earning(int amount)
        {
            m_person.AnnualIncome = amount;
            return this;
        }
    }   
    
}
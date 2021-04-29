namespace FluentBulider
{
    public class PersonInfoBuilder<SELF> : PersonBuilder where SELF : PersonInfoBuilder<SELF>
    {
        
        public SELF Called(string name)
        {
            m_person.SetName(name);
            return (SELF) this;
        }
    }
}
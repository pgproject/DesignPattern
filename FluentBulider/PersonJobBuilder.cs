namespace FluentBulider
{
    public class PersonJobBuilder<SELF> : PersonInfoBuilder<PersonJobBuilder<SELF>>
    where SELF : PersonJobBuilder<SELF>
    {
        public SELF WorkAsA(string position)
        {
            m_person.SetPosition(position);
            return (SELF) this;
        }
        
    }
}
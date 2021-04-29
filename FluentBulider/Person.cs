namespace FluentBulider
{
    public class Person
    {
        public string m_name { get; set; }
        public string m_osition { get; set; }

        public class Builder : PersonJobBuilder<Builder>
        {
            
        }

        public static Builder New => new Builder();
        
        public override string ToString()
        {
            return $"{nameof(m_name)}: {m_name}, {nameof(m_osition)}: {m_osition}";
        }

        public void SetName(string name)
        {
            m_name = name;
        }

        public void SetPosition(string position)
        {
            m_osition = position;
        }
    }
}
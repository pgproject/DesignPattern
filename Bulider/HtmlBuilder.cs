namespace Bulider
{
    public class HtmlBuilder
    {
        private readonly string m_rootName;
        private HtmlElement m_root = new HtmlElement();

        public HtmlBuilder(string rootName)
        {
            this.m_rootName = rootName;
            m_root.Name = rootName;
        }

        public HtmlBuilder AddChild(string childName, string childText)
        {
            var element = new HtmlElement(childName, childText);
            m_root.HtmlElements.Add(element);
            return this;
        }

        public override string ToString()
        {
            return m_root.ToString();
        }

        public void Clear()
        {
            m_root = new HtmlElement {Name = m_rootName};
        }
    }
    
}
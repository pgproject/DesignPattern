using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Bulider
{
    public class HtmlElement
    {
        public string Name { get; set; }
        public string Text { get; set; }
        public List<HtmlElement> HtmlElements = new List<HtmlElement>();
        
        private const int indentSize = 2;

        public HtmlElement(string name, string text)
        {
            Name = name;
            Text = text;
        }
        
        public HtmlElement() { }

        private string ToStringImpl(int indent)
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * (indent + 1)));
                sb.AppendLine(Text);
            }

            foreach (var htmlElement in HtmlElements)
            {
                sb.Append(htmlElement.ToStringImpl(indent + 1));
            }
            sb.AppendLine($"{i}<{Name}>");
            return sb.ToString();
        }

        public override string ToString()
        {
            return ToStringImpl(0);

        }
    }
}
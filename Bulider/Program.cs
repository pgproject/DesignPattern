using System;
using System.Text;

namespace Bulider
{
    class Program
    {
        static void Main(string[] args)
        {

            var hello = "Hello";
            var sb = new StringBuilder();
            sb.Append("<p>");
            sb.Append(hello);
            sb.Append("</p>");
            Console.WriteLine(sb);

            var words = new[] {"hello", "world"};
            sb.Clear();
            sb.Append("<ul>");
            foreach (var word in words)
            {
                sb.AppendFormat("<li>{0}</li>", word);
            }

            sb.Append("</ul>");
            Console.WriteLine(sb);


            var bulider = new HtmlBulider("ul");
            bulider.AddChild("li", "hello");
            bulider.AddChild("li", "world");
            
            Console.WriteLine(bulider.ToString());
        }
    }
}
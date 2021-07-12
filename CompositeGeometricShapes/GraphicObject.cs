using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeGeometricShapes
{
    public class GraphicObject
    {

        public virtual string Name { get; set; } = "Group";
        public string Color;

        private Lazy<List<GraphicObject>> m_childeren = new Lazy<List<GraphicObject>>();
        public List<GraphicObject> Children => m_childeren.Value;

        private void Print(StringBuilder sb, int depth)
        {
            sb.Append(new string('*', depth))
                .Append(string.IsNullOrWhiteSpace(Color) ? string.Empty : $"{Color}")
                .AppendLine(Name);
            foreach (var child in Children)
            {
                child.Print(sb, depth + 1);
            }
        }
        
        public override string ToString()
        {
            var sb = new StringBuilder();
            Print(sb, 0);
            return sb.ToString();
        }
        
    }

    public class Circle : GraphicObject
    {
        public override string Name => "Circle";
    }

    public class Square : GraphicObject
    {
        public override string Name => "Square";

    }
}
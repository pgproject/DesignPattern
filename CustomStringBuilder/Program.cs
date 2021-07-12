using System;
using CustomStringBuilderBuilder;

namespace CustomStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = new CodeBuilder();
            cb.AppendLine("Class Foo")
                .AppendLine("{")
                .AppendLine("}");

            Console.WriteLine(cb);
        }
    }
}
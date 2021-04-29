using System;

namespace FunctionalBuilderV2
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .Called("Sarah")
                .WarksAs("Developer")
                .Build();
            Console.WriteLine(person.Name);
        }
    }
}
using System;

namespace FunctionalBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonBuilder()
                .Called("Sarah")
                .WorkAs("Developer")
                .Build();
            Console.WriteLine(person.Name);
        }
    }
}
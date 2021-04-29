using System;

namespace FluentBulider
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPerson = Person.New
                .Called("Grzegorz")
                .WorkAsA("programer")
                .Build();
            Console.WriteLine(myPerson);
        }
    }
}
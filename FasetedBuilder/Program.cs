using System;

namespace FasetedBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            var personalBuilder = new PersonBuilder();
            Person person = personalBuilder.Lives
                .At("ul. Długa 15")
                .In("Krakow")
                .WithPostCode("30-162")
                .Works.At("Fabrikam")
                .AsA("Engineer")
                .Earning(2000);

            Console.WriteLine(person);

        }
    }
}
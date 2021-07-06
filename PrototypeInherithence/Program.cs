using System;

namespace PrototypeInherithence
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Employee();
            john.Names = new[] {"John", "Doe"};
            john.Address = new Address
            {
                HouseNumer = 123,
                StreetName = "London Road"
            };
            john.Salary = 321000;
            
            var copy = john.DeepCopy();
            
            copy.Names[1] = "Smith";
            copy.Address.HouseNumer++;
            copy.Salary = 123000;

            Console.WriteLine(john);
            Console.WriteLine(copy);
        }
        
    }
}
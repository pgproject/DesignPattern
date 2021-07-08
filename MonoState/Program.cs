using System;

namespace MonoState
{
    class Program
    {
        static void Main(string[] args)
        {
            var coe = new CEO();
            coe.Name = "Adan Smith";
            coe.Age = 55;

            var ceo2 = new CEO();

            Console.WriteLine(ceo2);
        }
    }
}
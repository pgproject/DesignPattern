using System;

namespace AbstractFactory
{
    internal class Coffee : IHotDrink
    {
        public void Consume()
        {
            Console.WriteLine("This coffe is sensational.");
        }
    }
}
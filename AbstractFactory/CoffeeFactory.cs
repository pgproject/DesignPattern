using System;

namespace AbstractFactory
{
    internal class CoffeeFactory : IHotDrinkFactory
    {
        public IHotDrink Prepare(int amount)
        {
            Console.WriteLine($"Grind some beans, boil, water, pour {amount} ml, add cream, sugar, enjoy!");
            return new Coffee();
        }
    }
}
using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class HotDrinkMachine
    {
        public enum AvailableDrink
        {
            Coffee, 
            Tea
        }

        private Dictionary<AvailableDrink, IHotDrinkFactory> m_factories =
            new Dictionary<AvailableDrink, IHotDrinkFactory>();

        public HotDrinkMachine()
        {
            foreach (AvailableDrink drink in Enum.GetValues(typeof(AvailableDrink)))
            {
                var factory = (IHotDrinkFactory) Activator.CreateInstance(
                    Type.GetType("AbstractFactory." + Enum.GetName(typeof(AvailableDrink), drink) + "Factory"));
                m_factories.Add(drink, factory);

            }
        }

        public IHotDrink MakeDrink(AvailableDrink drink, int amount)
        {
            return m_factories[drink].Prepare(amount);
        }

    }
}
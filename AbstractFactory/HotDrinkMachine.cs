using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public class HotDrinkMachine
    {
        /*public enum AvailableDrink
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
        }*/
        private List<Tuple<string, IHotDrinkFactory>> m_factories = new List<Tuple<string, IHotDrinkFactory>>();
        
        public HotDrinkMachine()
        {
            foreach (var type in typeof(HotDrinkMachine).Assembly.GetTypes())
            {
                if(typeof(IHotDrinkFactory).IsAssignableFrom(type) && !type.IsInterface)
                    m_factories.Add(Tuple.Create(
                        type.Name.Replace("Factory", string.Empty),
                        (IHotDrinkFactory)Activator.CreateInstance(type)
                        ));
            }
        }

        public IHotDrink MakeDrink()
        {
            Console.WriteLine("Available drinks:");
            for (int i = 0; i < m_factories.Count; i++)
            {
                var tuple = m_factories[i];
                Console.WriteLine($"{i}: {tuple.Item1}");
            }

            while (true)
            {
                string s;
                if ((s = Console.ReadLine()) != null
                    && int.TryParse(s, out int i)
                    && i >= 0
                    && i < m_factories.Count)
                {
                    Console.Write("Specify amount: ");
                    s = Console.ReadLine();
                    if (s != null
                        && int.TryParse(s, out int amount)
                        && amount > 0)
                    {
                        return m_factories[i].Item2.Prepare(amount);
                    }
                }

                Console.WriteLine("Incotect input, try again!");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using MoreLinq;

namespace SingletonImplement
{
    public class SingletonDatabase : IDatabase
    {
        private Dictionary<string, int> m_capitals;
        private static int m_instanceCount;

        public static int Count => m_instanceCount;
        private SingletonDatabase()
        {
            m_instanceCount++;
            Console.WriteLine("Initializing database");

            m_capitals = File.ReadAllLines(Path.Combine(new FileInfo(typeof(IDatabase).Assembly.Location).DirectoryName, "capital.txt"))
                .Batch(2)
                .ToDictionary(
                    list => list.ElementAt(0).Trim(),
                    list => int.Parse(list.ElementAt(1)));
        }
        
        public int GetPopulation(string name)
        {
            return m_capitals[name];
        }

        private static Lazy<SingletonDatabase> m_instance = new Lazy<SingletonDatabase>(() => new SingletonDatabase());

        public static SingletonDatabase Instance => m_instance.Value;
    }
}
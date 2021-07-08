using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using MoreLinq;

namespace SingletonImplement
{
    public class OrdinaryDatabase : IDatabase
    {
        private Dictionary<string, int> m_capitals;
        public OrdinaryDatabase()
        {
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
    }
}
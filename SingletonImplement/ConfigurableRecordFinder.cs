using System.Collections.Generic;

namespace SingletonImplement
{
    public class ConfigurableRecordFinder
    {
        private IDatabase m_database;

        public ConfigurableRecordFinder(IDatabase database)
        {
            this.m_database = database;
        }
        
        public int GetTotalPopulation(IEnumerable<string> names)
        {
            int result = 0;
            foreach (var name in names)
            {
                result += m_database.GetPopulation(name);
            }
            return result;
        }
    }
}
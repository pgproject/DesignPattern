using System;

namespace MonoState
{
    public class CEO
    {
        private static string m_name;
        private static int m_age;

        public string Name
        {
            get => m_name;
            set => m_name = value;
        }

        public int Age
        {
            get => m_age;
            set => m_age = value;
        }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Age)}: {Age}";
        }
    }
}
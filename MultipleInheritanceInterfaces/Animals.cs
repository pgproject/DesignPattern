using System;

namespace MultipleInheritanceInterfaces
{
    public class Bird : IBird
    {
        public int Weight { get; set; }
        public void Fly()
        {
            Console.WriteLine($"Soaring in the sky with wight {Weight}");
        }
    }

    public class Lizard : ILizard
    {
        public int Weight { get; set; }

        public void Crawl()
        {
            Console.WriteLine($"Crawling in the dirt with wight {Weight}");
        }
    }

    public class Dragon : IBird, ILizard
    {
        private Bird m_bird = new Bird();
        private Lizard m_lizard = new Lizard();
        private int m_weight;

        public void Fly()
        {
            m_bird.Fly();
        }

        public void Crawl()
        {
            m_lizard.Crawl();
        }

        public int Weight
        {
            get => m_weight;
            set
            {
                m_weight = value;
                m_bird.Weight = value;
                m_lizard.Weight = value;
            }
        }
    }
    
}
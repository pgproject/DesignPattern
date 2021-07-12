using System;

namespace MultipleInheritanceDefaultInterfaceMembers
{
    public interface ICreature
    {
        int Age { get; set; }
    }

    public interface IBird : ICreature
    {
        void Fly()
        {
            if (Age >= 0)
            {
                Console.WriteLine("I am flying.");
            }
        }
    }

    public interface ILizard : ICreature
    {
        void Crawl()
        {
            if (Age < 10)
            {
                Console.WriteLine("I am crawling.");
            }
        }
    }
}
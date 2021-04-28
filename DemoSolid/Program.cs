using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace DemoSolid
{
    class Program
    {

        public Program(IRelationShipBrowser browser)
        {
            foreach (var person in browser.FindAllChilderOf("John"))
            {
                Console.WriteLine($"John has a child called {person.Name}");
            }
        }
        
        static void Main(string[] args)
        {
            var parent = new Person {Name = "John"};
            var child = new Person {Name = "Chris"};
            var child2 = new Person {Name = "Mary"};

            var realtionship = new RelationShips();
            realtionship.AddParentAndChild(parent, child);
            realtionship.AddParentAndChild(parent, child2);

            new Program(realtionship);
        }
    }
    public enum RelationShip
    {
        Parent,
        Child,
        Sibling
    }
        
    public class Person
    {
        public string Name;
    }

    public interface IRelationShipBrowser
    {
        IEnumerable<Person> FindAllChilderOf(string name);
    }
        
    public class RelationShips : IRelationShipBrowser
    {
        private List<(Person, RelationShip, Person)> m_relations = new List<(Person, RelationShip, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            m_relations.Add((parent, RelationShip.Parent, child));
            m_relations.Add((child, RelationShip.Child, parent));
        }

        public IEnumerable<Person> FindAllChilderOf(string name)
        {
            return  m_relations.Where
            (x => x.Item1.Name == "John" 
                  && x.Item2 == RelationShip.Parent).Select(r => r.Item3);
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalBuilder
{
    public sealed class PersonBuilder
    {
        private readonly List<Func<Person, Person>> m_actions = new List<Func<Person, Person>>();

        public PersonBuilder Called(string name) => Do(person => person.Name = name);

        public Person Build() => m_actions.Aggregate(new Person(), (person, func) => func(person));
        public PersonBuilder Do(Action<Person> action) => AddAction(action);

        private PersonBuilder AddAction(Action<Person> action)
        {
            m_actions.Add(person =>
            {
                action(person);
                return person;
            });
            return this;

        }
        
    }
}
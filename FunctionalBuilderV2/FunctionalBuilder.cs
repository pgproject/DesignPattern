using System;
using System.Collections.Generic;
using System.Linq;

namespace FunctionalBuilderV2
{
    public class FunctionalBuilder<TSubject, TSelf> where TSelf : FunctionalBuilder<TSubject, TSelf> where TSubject : new()
    {
        private readonly List<Func<Person, Person>> m_actions = new List<Func<Person, Person>>();

        public Person Build() => m_actions.Aggregate(new Person(), (person, func) => func(person));
        public TSelf Do(Action<Person> action) => AddAction(action);

        private TSelf AddAction(Action<Person> action)
        {
            m_actions.Add(person =>
            {
                action(person);
                return person;
            });
            return (TSelf) this;

        }
    }
}
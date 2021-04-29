namespace FunctionalBuilderV2
{
    public class PersonBuilder : FunctionalBuilder<Person, PersonBuilder>
    {
        public PersonBuilder Called(string name) => Do(person => person.Name = name);

    }
}
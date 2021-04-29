namespace FunctionalBuilderV2
{
    public static class PersonBuilderExtensions
    {
        public static PersonBuilder WarksAs(this PersonBuilder builder, string position) =>
            builder.Do(person => person.Position = position);
    }
}
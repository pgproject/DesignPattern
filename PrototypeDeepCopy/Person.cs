﻿namespace PrototypeDeepCopy
{
    public class Person : IPrototype<Person>
    {
        public string[] Names;
        public Address Address;

        public Person(string[] names, Address address)
        {
            Names = names;
            Address = address;
        }

        public Person DeepCopy()
        {
            return new Person(Names, Address.DeepCopy());
        }

        public override string ToString()
        {
            return $"{nameof(Names)}: {string.Join(" ",Names)}, {nameof(Address)} : {Address}";
        }

        public Person(Person other)
        {
            Names = other.Names;
            Address = new Address(other.Address);
        }
    }
}
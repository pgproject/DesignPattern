﻿using System;

namespace PrototypeDeepCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person(new[] {"John", "Smith"}, new Address("London Road", 123));

            var jane = john.DeepCopy();
            jane.Address.HouseNumber = 321;
            
            Console.WriteLine(john);
            Console.WriteLine(jane);
        }
    }
}
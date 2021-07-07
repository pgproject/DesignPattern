﻿using System;

namespace SingletonImplement
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = SingletonDatabase.Instance;

            var city = "Tokyo";

            Console.WriteLine($"{city} has population {db.GetPopulation(city)}");
        }
    }
}
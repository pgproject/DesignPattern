using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        public string Name;
        public string Crust;
        public string Souce;
        public List<string> Additives = new List<string>();

        public void Preapering()
        {
            Console.WriteLine("Prepering " + Name);
            Console.WriteLine("Making crust...");
            Console.WriteLine("Adding souce...");
            Console.WriteLine("Additivies: ");
            for (int i = 0; i < Additives.Count; i++)
            {
                Console.WriteLine("  "+Additives[i]);
            }
        }
        public void Beaking()
        {
            Console.WriteLine("Beaking: 25 minutes in 350 celscius deagres.");
        }
        public void Cutting()
        {
            Console.WriteLine("Cutting for eight pieces.");
        }
        public void Packing()
        {
            Console.WriteLine("Pakcking for our official pizza box/");
        }
        public string DownloadName()
        {
            return Name;
        }
    }
}
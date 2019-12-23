using System;
using System.Collections.Generic;

namespace Factory
{
    public abstract class Pizza
    {
        public string Name;
        public Crust Crust;
        public Souce Souce;
        public Vegetables[] Vegetables;
        public Cheasse Cheasse;
        public Peperonni Peperonni;
        public Clams Clams;

        public abstract void Preparation();


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
        public void SetName(string name)
        {
            this.Name = name;
        }
        public string DownloadName()
        {
            return Name;
        }
        public String ToString()
        {
            return null;
        }
    }
}
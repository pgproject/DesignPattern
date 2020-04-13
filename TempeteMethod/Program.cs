using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TempeteMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck[] ducks =
            {
                new Duck("Kaczor Duffy", 8),
                new Duck("Kaczor Dawey", 2),
                new Duck("Kaczor Howard", 7),
                new Duck("Kaczor Louie", 2),
                new Duck("Kaczor Donald", 10),
                new Duck("Kaczor Huey", 2),
            };
            Console.WriteLine("Przed sortowaniem:");
            Show(ducks);
            Array.Sort(ducks);
            Console.WriteLine("Po sortowaniu:");
            Show(ducks);
            Console.ReadKey();
        }
        public static void Show(Duck []ducks )
        {
            for (int i = 0; i < ducks.Length; i++)
            {
                Console.WriteLine(ducks[i]._name + " " +ducks[i]._weight); ;
            }
        }
    }
}

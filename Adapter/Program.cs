using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            WildDuck wildDuck = new WildDuck();

            WildTurkey wildTurkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(wildTurkey);
            ITurkey duckAdapter = new DuckAdapter(wildDuck);

            Console.WriteLine("Indyk mówi:");
            wildTurkey.Bubble();
            wildTurkey.Fly();

            Console.WriteLine("Kaczka mówi:");
            TestDuck(wildDuck);

            Console.WriteLine("Adapter indyka mówi");
            TestDuck(turkeyAdapter);

            Console.WriteLine("Adapter kaczki mówi:");
            TestTurkey(duckAdapter);

            Console.ReadKey();
        }
        static void TestDuck(IDuck duck)
        {
            duck.Mop();
            duck.Fly();
        }
        static void TestTurkey(ITurkey turkey)
        {
            turkey.Bubble();
            turkey.Fly();
        }
    }
}

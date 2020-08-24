using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine(5);
            Console.WriteLine(vendingMachine);

            vendingMachine.PutCion();
            vendingMachine.TwistKnob();

            Console.WriteLine(vendingMachine);

            vendingMachine.PutCion();
            vendingMachine.ReturnCoin();
            vendingMachine.TwistKnob();

            Console.WriteLine(vendingMachine);

            vendingMachine.PutCion();
            vendingMachine.TwistKnob();
            vendingMachine.PutCion();
            vendingMachine.TwistKnob();
            vendingMachine.ReturnCoin();

            Console.WriteLine(vendingMachine);

            vendingMachine.PutCion();
            vendingMachine.PutCion();
            vendingMachine.TwistKnob();
            vendingMachine.PutCion();
            vendingMachine.TwistKnob();
            vendingMachine.PutCion();
            vendingMachine.TwistKnob();

            Console.WriteLine(vendingMachine);
            Console.ReadKey();
        }
    }
}

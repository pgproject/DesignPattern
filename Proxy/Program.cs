using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine(10, "Kraków");

            VendingMachineMonitor vendingMachineMonitor = new VendingMachineMonitor(vendingMachine);
            
            Console.WriteLine(vendingMachine);
            vendingMachine.PutCoin();
            vendingMachine.TwistKnob();
            Console.WriteLine(vendingMachine);
            vendingMachine.PutCoin();
            vendingMachine.TwistKnob();
            vendingMachine.PutCoin();
            vendingMachine.TwistKnob();
            
            vendingMachineMonitor.Raport();
            Console.ReadKey();
        }
    }
}
using System;

namespace Proxy
{
    public class VendingMachineMonitor
    {
        private VendingMachine m_vendingMachine;

        public VendingMachineMonitor(VendingMachine vendingMachine)
        {
            this.m_vendingMachine = vendingMachine;
        }

        public void Raport()
        {
            Console.WriteLine("Automat sprzedający:" + m_vendingMachine.GetLocalization());
            Console.WriteLine("Towar: " + m_vendingMachine.GetAmountOfGum());
            Console.WriteLine("Bieżacy stan urządzenia: " + m_vendingMachine.GetState());
        }
    }
}
using System;

namespace State.States
{
    public class GumSoldOutState : IState
    {
        private VendingMachine m_vendingMachine;

        public GumSoldOutState(VendingMachine mVendingMachine)
        {
            this.m_vendingMachine = mVendingMachine;
        }
        public void PutCoin()
        {
            Console.WriteLine("Brak gum.");
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Nie wrzuciłeś monety.");
        }

        public void TwistKnob()
        {
            Console.WriteLine("Brak gum");
        }

        public void Issue()
        {
            Console.WriteLine("Brak gum");
        }
    }
}
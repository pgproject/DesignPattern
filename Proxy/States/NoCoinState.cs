using System;

namespace Proxy.States
{
    public class NoCoinState : IState
    {

        private VendingMachine m_vendingMachine;

        public NoCoinState(VendingMachine mVendingMachine)
        {
            this.m_vendingMachine = mVendingMachine;
        }
        public void PutCoin()
        {
            Console.WriteLine("Moneta przyjęta");
            m_vendingMachine.SetState(m_vendingMachine.GetIsCoinState());
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Nie włożyłeś monety");
        }

        public void TwistKnob()
        {
            Console.WriteLine("Zanim przekręcisz gałkę wrzuć monetę");
        }

        public void Issue()
        {
            Console.WriteLine("Najpierw zapłać");
        }
    }
}
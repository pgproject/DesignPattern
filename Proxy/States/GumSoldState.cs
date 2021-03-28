using System;

namespace Proxy.States
{
    public class GumSoldState : IState
    {
        private VendingMachine m_vendingMachine;

        public GumSoldState(VendingMachine mVendingMachine)
        {
            this.m_vendingMachine = mVendingMachine;
        }
        public void PutCoin()
        {
            Console.WriteLine("Proszę czekać na gumę");
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Niestety nie można zwrócić monety po przekeceniu gałki");
        }

        public void TwistKnob()
        {
            Console.WriteLine("Nie dostaniesz gumy tylko dlatego, że przekręciłeś drugi raz.");
        }

        public void Issue()
        {
            m_vendingMachine.RelaseGum();
            if (m_vendingMachine.GetAmountOfGum() > 0)
            {
                m_vendingMachine.SetState(m_vendingMachine.GetNoCoinState());
            }
            else
            {
                Console.WriteLine("Ups, koniec gum");
                m_vendingMachine.SetState(m_vendingMachine.GetGumSoldOutState());
            }
        }
    }
}
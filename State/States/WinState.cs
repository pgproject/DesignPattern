using System;

namespace State.States
{
    public class WinState : IState
    {
        private VendingMachine m_vendingMachine;

        public WinState(VendingMachine mVendingMachine)
        {
            this.m_vendingMachine = mVendingMachine;
        }
        public void PutCoin()
        {
            Console.WriteLine("Nie możesz teraz wrzucić monety.");
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Nie możesz teraz zwrócić monety.");
        }

        public void TwistKnob()
        {
            Console.WriteLine("Nie możesz przekręcić gałki drugi raz.");
        }

        public void Issue()
        {
            Console.WriteLine("Wygrałeś! Dostajesz drugą gumę.");
            m_vendingMachine.RelaseGum();
            if (m_vendingMachine.GetAmountOfGum() == 0)
            {
                m_vendingMachine.SetState(m_vendingMachine.GetGumSoldOutState());
            }
            else
            {
                m_vendingMachine.RelaseGum();
                if (m_vendingMachine.GetAmountOfGum() > 0)
                {
                    m_vendingMachine.SetState(m_vendingMachine.GetNoCoinState());
                }
                else
                {
                    Console.WriteLine("Ups, koniec gum.");
                    m_vendingMachine.SetState(m_vendingMachine.GetGumSoldOutState());
                }
            }
            
        }
    }
}
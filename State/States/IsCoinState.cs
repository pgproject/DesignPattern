using System;

namespace State.States
{
    public class IsCoinState : IState
    {
        public VendingMachine m_vendingMachine;
        private Random m_random = new Random();
        public IsCoinState(VendingMachine mVendingMachine)
        {
            this.m_vendingMachine = mVendingMachine;
        }
        public void PutCoin()
        {
            Console.WriteLine("Nie możesz włóżyć więcej niż jednej monety");
        }

        public void ReturnCoin()
        {
            Console.WriteLine("Moneta zwrócona");
            m_vendingMachine.SetState(m_vendingMachine.GetNoCoinState());
        }

        public void TwistKnob()
        {
            Console.WriteLine("Obróciłeś gałkę...");
            int win = m_random.Next();
            if (win == 0)
            {
                m_vendingMachine.SetState(m_vendingMachine.GetWinState());
            }
            else
            {
                m_vendingMachine.SetState(m_vendingMachine.GetGumSoldState());
            }
        }

        public void Issue()
        {
            Console.WriteLine("Nie wydano gumy");
        }
    }
}
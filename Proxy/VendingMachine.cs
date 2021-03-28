using System;
using Proxy.States;

namespace Proxy
{
    public class VendingMachine
    {
        private IState m_gumSoldOut;
        private IState m_noCoin;
        private IState m_isCoin;
        private IState m_gumSold;
        private IState m_win;
        
        private IState m_state;
        private int m_amountOfGum = 0;
        private string m_localization;
        public VendingMachine(int amountOfGum, string localization)
        {
            this.m_amountOfGum = amountOfGum;
            this.m_localization = localization;
            m_gumSoldOut = new GumSoldOutState(this);
            m_noCoin = new NoCoinState(this);
            m_isCoin = new IsCoinState(this);
            m_gumSold = new GumSoldState(this);
            m_win = new WinState(this);
            m_state = m_gumSoldOut;
            if (m_amountOfGum > 0)
            {
                m_state = m_noCoin;
            }
        }

        public void PutCoin()
        {
            m_state.PutCoin();
        }

        public void ReturnCoin()
        {
            m_state.ReturnCoin();
        }

        public void TwistKnob()
        {
            m_state.TwistKnob();
            m_state.Issue();
        }

        public void RelaseGum()
        {
            Console.WriteLine("Wypada guma");
            if (m_amountOfGum != 0)
            {
                m_amountOfGum--;
            }
        }
        public void SetState(IState state)
        {
            this.m_state = state;
        }

        public IState GetIsCoinState()
        {
            return m_isCoin;
        }

        public IState GetNoCoinState()
        {
            return m_noCoin;
        }

        public IState GetGumSoldState()
        {
            return m_gumSold;
        }

        public IState GetGumSoldOutState()
        {
            return m_gumSoldOut;
        }

        public IState GetWinState()
        {
            return m_win;
        }
        
        public int GetAmountOfGum()
        {
            return m_amountOfGum;
        }

        public string GetLocalization()
        {
            return m_localization;
        }

        public IState GetState()
        {
            return m_state;
    }
    }
}

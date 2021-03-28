namespace Proxy
{
    public interface IState
    {
        void PutCoin();
        void ReturnCoin();
        void TwistKnob();
        void Issue();
    }
}
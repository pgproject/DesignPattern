namespace State
{
    public interface IState
    {
        void PutCoin();
        void ReturnCoin();
        void TwistKnob();
        void Issue();
    }
}
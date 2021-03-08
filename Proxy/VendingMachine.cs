namespace Proxy
{
    public class VendingMachine
    {
        private string m_localization;

        public VendingMachine(string mLocalization)
        {
            this.m_localization = mLocalization;
        }

        public string GetLocalization()
        {
            return m_localization;
        }
    }
}
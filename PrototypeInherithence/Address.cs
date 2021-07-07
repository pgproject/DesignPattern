namespace PrototypeInherithence
{
    public class Address : IDeepCopyable<Address>
    {
        public string StreetName;
        public int HouseNumer;

        public Address()
        {
            
        }
        
        public Address(string streetName, int houseNumer)
        {
            StreetName = streetName;
            HouseNumer = houseNumer;
        }


        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, " + $"{nameof(HouseNumer)}: {HouseNumer}";
        }

        public void CopyTo(Address target)
        {
            target.StreetName = StreetName;
            target.HouseNumer = HouseNumer;
        }
    }
}
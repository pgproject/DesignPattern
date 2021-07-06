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

        public Address DeepCopy()
        {
            return (Address) MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{nameof(StreetName)}: {StreetName}, " + $"{nameof(HouseNumer)}: {HouseNumer}";
        }
    }
}
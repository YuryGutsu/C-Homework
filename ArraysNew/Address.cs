

namespace ArraysNew;

internal class Address
{
    private const int max_house_number = 1000;
    private const int max_flat_number = 10000;
    private int _numberOfHouse;
    private int _numberOfFlat;
    public string City { get; set; }
    public string Street { get; set; }
    public int NumberOfHouse
    {
        get
        {
            return _numberOfHouse;
        }
        set
        { 
            if (value > 0 && value < max_house_number)
            {
                _numberOfHouse = value;
            }
        }
    }
    public int NumberOfFlat
    {
        get
        {
            return _numberOfFlat;
        }
        set
        {
            if (value > 0 && value < max_flat_number)
            {
                _numberOfFlat= value;
            }
        }
    }

    public Address(string city, string street, int numberOfHouse, int numberOfFlat)
    {
        City = city;
        Street = street;
        NumberOfHouse = numberOfHouse;
        NumberOfFlat = numberOfFlat;
    }
}

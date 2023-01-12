

namespace UniversityEmployee;

internal class Address
{
    private const int max_builging_number = 1000;
    
    private int _numberOfBuilding;
    public string City { get; set; }
    public string Street { get; set; }
    public int NumberOfBuilding
    {
        get
        {
            return _numberOfBuilding;
        }
        set
        { 
            if (value > 0 && value < max_builging_number)
            {
                _numberOfBuilding = value;
            }
        }
    }

    public Address(string city, string street, int numberOfBuilding)
    {
        City = city;
        Street = street;
        NumberOfBuilding = numberOfBuilding;
    }
}

namespace UniversityEmployee;

public class Address
{
    private const int _max_builging_number = 1000;
    
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
            if (value > 0 && value < _max_builging_number)
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
    public override string ToString()
    {
        return $"{City} {Street} {NumberOfBuilding}";
    }
    public override bool Equals(object obj)
    {
        if (obj == null || obj is not Address address)
        {
            return false;
        }

        return address.NumberOfBuilding.Equals(NumberOfBuilding)
            && address.Street.Equals(Street)
            && address.City.Equals(City);
    }
    public override int GetHashCode()
    {
        return NumberOfBuilding + Street.GetHashCode() + City.GetHashCode();
    }
}

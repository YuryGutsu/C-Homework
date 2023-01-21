using System.IO;

namespace UniversityEmployee;

public class Building
{
    public List<Room> Rooms;
    public Address Address { get; set; }

    public Building (List<Room> rooms, Address address)
    {
        Rooms = rooms;
        Address = address;
    }
    public override bool Equals(object obj)
    {
        if (obj == null || obj is not Building building)
        {
            return false;
        }

        return building.Address.Equals(Address)
            && building.Rooms.Equals(Rooms);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

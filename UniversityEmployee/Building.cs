using System.Collections.Generic;

namespace UniversityEmployee;

public class Building
{
    public List<Room> Rooms { get; set; }
    public Address Address { get; set; }

    public Building(List<Room> rooms, Address address)
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

        bool result = building.Address.Equals(Address);
        if (Rooms.Count == building.Rooms.Count)
        {
            for (var i = 0; i < Rooms.Count; i++)
            {
                result &= building.Rooms[i].Equals(Rooms[i]);
            }
        }
        return result;
    }
    public override int GetHashCode()
    {
        return Rooms.GetHashCode() + Address.GetHashCode();
    }
}

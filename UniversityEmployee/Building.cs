

namespace UniversityEmployee;

internal class Building
{
    public List<Room> Rooms;
    public Address Address { get; set; }

    public Building (List<Room> rooms, Address address)
    {
        Rooms = rooms;
        Address = address;
    }
}

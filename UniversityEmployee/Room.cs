

namespace UniversityEmployee;

internal class Room
{
    public RoomType TypeOfRoom { get; set; }

    public Room(RoomType roomType)
    {
        TypeOfRoom = roomType;
    }
}

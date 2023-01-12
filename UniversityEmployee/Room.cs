

namespace UniversityEmployee;

internal class Room
{
    private int _numberOfRoom;
    public RoomType TypeOfRoom { get; set; }
    public int NumberOfRoom
    {
        get
        {
            return _numberOfRoom;
        }
        set
        {
            if (value > 0)
            {
                _numberOfRoom = value;
            }
        }
    }
    public Room(RoomType typeOfRoom, int numberOfRoom)
    {
        TypeOfRoom = typeOfRoom;
        NumberOfRoom = numberOfRoom;
    }
}

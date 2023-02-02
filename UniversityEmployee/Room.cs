namespace UniversityEmployee;

public class Room
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
            if (value < 0)
            {
                throw new ArgumentException("incorrect value NumberOfRoom, it must be > 0");
            }
            _numberOfRoom = value;
        }
    }

    public Room(RoomType typeOfRoom, int numberOfRoom)
    {
        TypeOfRoom = typeOfRoom;
        NumberOfRoom = numberOfRoom;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not Room room)
        {
            return false;
        }

        return room.TypeOfRoom.Equals(TypeOfRoom)
            && room.NumberOfRoom.Equals(NumberOfRoom);
    }

    public override int GetHashCode()
    {
        return NumberOfRoom.GetHashCode() + TypeOfRoom.GetHashCode();
    }
}

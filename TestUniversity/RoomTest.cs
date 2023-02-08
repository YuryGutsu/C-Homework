using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class RoomTest
{
    Room room = new Room(RoomType.LectionRoom, 1);

    [TestMethod]
    public void TestRoomEqualsPositive()
    {
        var r = new Room(RoomType.LectionRoom, 1);
        Assert.AreEqual(room, r);
    }

    [TestMethod]
    public void TestRoomTypesEqualsNegative()
    {
        var r = new Room(RoomType.SeminarRoom, 1);
        Assert.AreNotEqual(room, r);
    }

    [TestMethod]
    public void TestRoomsEqualsNegative()
    {
        var r = new Room(RoomType.LectionRoom, 11);
        Assert.AreNotEqual(room, r);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestRoomNumberOfRoomThrowsException()
    {
        _ = new Room(RoomType.LectionRoom, -1);
    }
}


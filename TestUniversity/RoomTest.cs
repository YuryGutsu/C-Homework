using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class RoomTest
{
    [TestMethod]
    public void TestRoomEqualsPositive()
    {
        var room = new Room(RoomType.LectionRoom, 1);
        var r = new Room(RoomType.LectionRoom, 1);
        Assert.AreEqual(room, r);
    }

    [TestMethod]
    public void TestRoomTypesEqualsNegative()
    {
        var room = new Room(RoomType.LectionRoom, 1);
        var r = new Room(RoomType.SeminarRoom, 1);
        Assert.AreNotEqual(room, r);
    }

    [TestMethod]
    public void TestRoomsEqualsNegative()
    {
        var room = new Room(RoomType.LectionRoom, 1);
        var r = new Room(RoomType.LectionRoom, 11);
        Assert.AreNotEqual(room, r);
    }

    [TestMethod]
    public void TestRoomNumberOfRoomThrowsException()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Room(RoomType.LectionRoom, -1));
        Assert.AreEqual("incorrect value NumberOfRoom, it must be > 0", ex.Message);
    }
}


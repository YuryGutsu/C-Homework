using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class BuildingTest
{
    [TestMethod]
    public void TestBuildingsEqualsPositive()
    {
        var building = new Building
             (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},
             new Address("Minsk", "ul. Brovki", 1));
        var b = new Building
             (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},
             new Address("Minsk", "ul. Brovki", 1));
        Assert.AreEqual(building, b);
    }
    [TestMethod]
    public void TestTheRoomsNumberInBuildingsNotEquals()
    {
        var building = new Building
             (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},   
             new Address("Minsk", "ul. Brovki", 1));
        var b = new Building
             (new List<Room>() {
                new Room(RoomType.LectionRoom, 111),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},
             new Address("Minsk", "ul. Brovki", 1));
        Assert.AreNotEqual(building, b);
    }

    [TestMethod]
    public void TestNumberOfRoomsInBuildingsNotEquals()
    {
        var building = new Building
             (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},
             new Address("Minsk", "ul. Brovki", 1));
        var b = new Building
             (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.AuxiliaryRoom, 4)},
             new Address("Minsk", "ul. Brovki", 1));
        Assert.AreNotEqual(building, b);
    }
}

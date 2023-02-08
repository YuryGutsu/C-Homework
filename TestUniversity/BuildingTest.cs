using System.Net;
using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class BuildingTest
{
    Building building = new Building
             (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},
             new Address("Minsk", "ul. Brovki", 1));

    [TestMethod]
    public void TestBuildingsEqualsPositive()
    {
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
    public void BuildingsGetHashCodesAreEquals()
    {
        var b = new Building
     (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},
     new Address("Minsk", "ul. Brovki", 1));
        Assert.AreEqual(building.GetHashCode(), b.GetHashCode());
    }

    [TestMethod]
    public void TestTheRoomsNumberInBuildingsNotEquals()
    {
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
        var b = new Building
             (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.AuxiliaryRoom, 4)},
             new Address("Minsk", "ul. Brovki", 1));
        Assert.AreNotEqual(building, b);
    }
}

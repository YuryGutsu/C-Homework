using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]
public class UniversityTest
{
    [TestMethod]
    public void TestAddEmployeePositive()
    {
        var employees = new List<UniversityEmployee.UniversityEmployee>()
        {new Teacher(
                new Person("Bob", "Dylan"),
                "AB1111",
                new Course("Math", "Algebra")),
        new Teacher(
           new Person("Mike", "Spencer"),
           "AB2222",
           new Course("History", "Ancient"))
        };
        var employeeAdded = new Teacher(
              new Person("Mike", "Spencer"),
           "AB9999",
           new Course("History", "Ancient"));
        var buildings = new List<Building>() {
            new Building
            (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},
            new Address("Minsk", "ul. Brovki", 1)),
            new Building
            (new List<Room>() {
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 23) },
            new Address("Minsk", "ul. Brovki", 2))
        };
        var employeeRector = new Rector(
                new Person("Taras", "Bulba"),
                "RR1111",
                "BGUIR");
        var un = new University(employees, buildings, employeeRector);
        var emp = employees.Count;
        var newun = un.AddEmployee(employeeAdded);
        var empFinal = employees.Count;
        Assert.AreEqual(empFinal, (emp + 1));
    }

    [TestMethod]
    public void TestNotAddEmployeePositive()
    {
        var employees = new List<UniversityEmployee.UniversityEmployee>()
        {new Teacher(
                new Person("Bob", "Dylan"),
                "AB1111",
                new Course("Math", "Algebra")),
        new Teacher(
           new Person("Mike", "Spencer"),
           "AB2222",
           new Course("History", "Ancient"))
        };
        var employeeAdded = new Teacher(
              new Person("Mike", "Spencer"),
           "AB2222",
           new Course("History", "Ancient"));
        var buildings = new List<Building>() {
            new Building
            (new List<Room>() {
                new Room(RoomType.LectionRoom, 1),
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 3),
                new Room(RoomType.AuxiliaryRoom, 4)},
            new Address("Minsk", "ul. Brovki", 1)),
            new Building
            (new List<Room>() {
                new Room(RoomType.LaboratoryRoom, 22),
                new Room(RoomType.SeminarRoom, 23) },
            new Address("Minsk", "ul. Brovki", 2))
        };
        var employeeRector = new Rector(
                new Person("Taras", "Bulba"),
                "RR1111",
                "BGUIR");
        var un = new University(employees, buildings, employeeRector);
        var emp = employees.Count;
        var newun = un.AddEmployee(employeeAdded);
        var empFinal = employees.Count;
        Assert.AreEqual(empFinal, (emp));
    }
}

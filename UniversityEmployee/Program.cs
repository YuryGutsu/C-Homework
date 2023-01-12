

namespace UniversityEmployee;

internal class Program
{
    static void Main(string[] args)
    {
                                            
        var employee1 = new Teacher (new Person("Bob", "Dilan"), "AB1111", new Course ("Math", "Algebra"));
        var employee2 = new Teacher (new Person("Mike", "Spencer"), "AB2222", new Course ("History", "Ancient"));
        var employee3 = new TeacherWithDegree (new Person("Sara", "White"), "AB3333", new Course("Biology", "Pathology"),
                                                                                            "Magistr", "Rector");
        var employee4 = new SupportStaff (new Person("Dory", "Minny"), "GG1111", "Guard");
        var employee5 = new SupportStaff (new Person("Serge", "McNill"), "GG2222", "Janitor");
        var employee6 = new SupportStaff (new Person("Ben", "Brown"), "GG3333", "Gardener");
        var employeeRector = new Rector (new Person("Taras", "Bulba"), "RR1111", "BGUIR");

        List<UniversityEmployee> employees = new() { employee1, employee2, employee3,employee4,
                                                     employee5, employee6, employeeRector };
        var Building1 = new Building(new List<Room>() {new Room(RoomType.LectionRoom, 1),
                                                          new Room(RoomType.LaboratoryRoom, 2),
                                                          new Room(RoomType.SeminarRoom, 3),
                                                          new Room(RoomType.AuxiliaryRoom, 4)},
                                                          new Address("Minsk", "ul. Brovki", 1));

        var building2 = new Building(new List<Room>() {   new Room(RoomType.LaboratoryRoom, 22),
                                                          new Room(RoomType.SeminarRoom, 23) },
                                                          new Address("Minsk", "ul. Brovki", 2));

        var building3 = new Building(new List<Room>() {   new Room(RoomType.LectionRoom, 31),
                                                          new Room(RoomType.AuxiliaryRoom, 34)},
                                                          new Address("Minsk", "ul. Brovki", 3));

        List<Building> buildings = new() {Building1, building2, building3 };

        var universityBguir = new University(employees, buildings, employeeRector);

        foreach (var employee in employees)
        {
            Console.WriteLine(employee.GetOfficialDuties());
        }

        Console.WriteLine("/n");

        foreach(var employee in employees)
        {
            if (employee is Teacher)
            {
                Console.WriteLine(employee.GetOfficialDuties());
            }
        }
    }
    
}
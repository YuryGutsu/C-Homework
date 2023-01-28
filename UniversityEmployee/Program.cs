namespace UniversityEmployee;

public class Program
{
    static void Main(string[] args)
    {
        var employee1 = new Teacher(new Person("Bob", "Dylan"), "AB1111", new Course("Math", "Algebra"));
        var employee2 = new Teacher(new Person("Mike", "Spencer"), "AB2222", new Course("History", "Ancient"));
        var employee3 = new Teacher(new Person("Dan", "Spencer"), "AB2223", new Course("Math", "Algebra"));
        var employee4 = new Teacher(new Person("Andry", "Anderson"), "AB2224", new Course("Math", "Geometry"));
        var employee5 = new TeacherWithDegree(new Person("Sara", "White"), "AB3333", new Course("Biology", "Pathology"),
                                                                                            "Magistr", "Rector");
        var employee6 = new SupportStaff(new Person("Dory", "Minny"), "GG1111", "Guard");
        var employee7 = new SupportStaff(new Person("Serge", "McNill"), "GG2222", "Janitor");
        var employee8 = new SupportStaff(new Person("Ben", "Brown"), "GG3333", "Gardener");
        var employeeRector = new Rector(new Person("Taras", "Bulba"), "RR1111", "BGUIR");
      
        var employees = new List<UniversityEmployee>() { employee1, employee2, employee3,employee4,
                                                         employee5, employee6, employee7, employee8, employeeRector };
        var building1 = new Building(new List<Room>() {new Room(RoomType.LectionRoom, 1),
                                                          new Room(RoomType.LaboratoryRoom, 22),
                                                          new Room(RoomType.SeminarRoom, 3),
                                                          new Room(RoomType.AuxiliaryRoom, 4)},
                                                          new Address("Minsk", "ul. Brovki", 1));

        var building2 = new Building(new List<Room>() {   new Room(RoomType.LaboratoryRoom, 22),
                                                          new Room(RoomType.SeminarRoom, 23) },
                                                          new Address("Minsk", "ul. Brovki", 2));

        var building3 = new Building(new List<Room>() {   new Room(RoomType.LectionRoom, 31),
                                                          new Room(RoomType.AuxiliaryRoom, 34)},
                                                          new Address("Minsk", "ul. Brovki", 3));

        var buildings = new List<Building>() { building1, building2, building3 };

        var universityBguir = new University(employees, buildings, employeeRector);
        
        Console.WriteLine(universityBguir.AddEmployee(new Teacher(new Person("Dylan", "Bob"), "AB2229", new Course("Math", "Algebra"))));
        Console.WriteLine(universityBguir.AddEmployee(employee5));
        Console.WriteLine();

        var filterEmployee1 = universityBguir.Employees.Where(x => x.Person.LastName.StartsWith('B'))
                                                       .OrderBy(x => x.TaxId)
                                                       .ToList();

        foreach (var item in filterEmployee1)
        {
            Console.WriteLine(item.GetOfficialDuties());
        }

        Console.WriteLine();

        var filterEmployee2 = universityBguir.Employees
            .Where(x => (x is Teacher teacher) && teacher.Course.CourseName.Equals("Math"))
            .ToList();

        foreach (var item in filterEmployee2)
        {
            Console.WriteLine(item.GetOfficialDuties());
        }

        Console.WriteLine();

        var filterEmployee3 = universityBguir.Employees
            .Where(x => (x is SupportStaff))
            .Select(supportstaff => (supportstaff.TaxId, ((SupportStaff) supportstaff).StaffDuty))
            .ToList();

        foreach (var item in filterEmployee3)
        {
            Console.WriteLine("TaxId = {0}, StaffDuty = {1}", item.TaxId, item.StaffDuty);
        }

        Console.WriteLine();

        var filterBuilding1 = universityBguir.Buildings
            .Where(x => x.Rooms.Any(room => room.NumberOfRoom.Equals(22)))
            .Select(x => x.Address)
            .ToList();

        foreach (var item in filterBuilding1)
        {
            Console.WriteLine(item);
        }
        /*var filterBuilding2 = 
            //.Where(x => x.Rooms.Count().Equals(universityBguir.Buildings.Rooms.Max(x => x.Rooms)))
            (from x in universityBguir.Buildings
             orderby x.Rooms
             select x)
            .ToList();

        foreach (var item in filterBuilding2)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine();*/

        foreach (var employee in employees)
        {
            Console.WriteLine(employee.GetOfficialDuties());
        }

        Console.WriteLine();

        foreach (var employee in employees)
        {
            if (employee is Teacher)
            {
                Console.WriteLine(employee.GetOfficialDuties());
            }
        }
    }

}
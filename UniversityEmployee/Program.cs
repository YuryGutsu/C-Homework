namespace UniversityEmployee;

internal class Program
{
    static void Main(string[] args)
    {
        UniversityEmployee employee1 = new Teacher ("Bob Dilan", "AB1111", new Course ("Math", "Algebra"));
        UniversityEmployee employee2 = new Teacher ("Mike Spencer", "AB2222", new Course ("History", "Ancient"));
        UniversityEmployee employee3 = 
            new DegreeTeacher ("Sara White", "AB3333", new Course("Biology", "Pathology"), "Magistr", "Rector");
        UniversityEmployee employee4 = new SupportStaff ("Dory Minny", "GG1111", "Guard");
        UniversityEmployee employee5 = new SupportStaff ("Serge McNill", "GG2222", "Janitor");
        UniversityEmployee employee6 = new SupportStaff ("Ben Brown", "GG3333", "Gardener");

        UniversityEmployee[] employees = new [] { employee1, employee2, employee3, employee4, employee5, employee6 };

        foreach (var employee in employees)
        {
            Console.WriteLine(employee.GetOfficialDuties());
        }

        Console.WriteLine("\n");

        foreach(var employee in employees)
        {
            if (employee.GetType() == typeof(Teacher) || employee.GetType() == typeof(DegreeTeacher))
            {
                Console.WriteLine(employee.GetOfficialDuties());
            }
        }
    }
    
}
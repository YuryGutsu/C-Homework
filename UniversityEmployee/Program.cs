

namespace UniversityEmployee;

internal class Program
{
    static void Main(string[] args)
    {
       /*                                           TASK 2
        *                                           
        var employee1 = new Teacher (new Person("Bob", "Dilan"), "AB1111", new Course ("Math", "Algebra"));
        var employee2 = new Teacher (new Person("Mike", "Spencer"), "AB2222", new Course ("History", "Ancient"));
        var employee3 = new TeacherWithDegree (new Person("Sara", "White"), "AB3333", new Course("Biology", "Pathology"),
                                                                                            "Magistr", "Rector");
        var employee4 = new SupportStaff (new Person("Dory", "Minny"), "GG1111", "Guard");
        var employee5 = new SupportStaff (new Person("Serge", "McNill"), "GG2222", "Janitor");
        var employee6 = new SupportStaff (new Person("Ben", "Brown"), "GG3333", "Gardener");

        List<UniversityEmployee> employees = new() { employee1, employee2, employee3, employee4, employee5, employee6 };

        foreach (var employee in employees)
        {
            Console.WriteLine(employee.GetOfficialDuties());
        }

        Console.WriteLine("\n");

        foreach(var employee in employees)
        {
            if (employee is Teacher)
            {
                Console.WriteLine(employee.GetOfficialDuties());
            }
        }*/


        University universityRti = new University ();
    }
    
}
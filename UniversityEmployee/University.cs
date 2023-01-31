namespace UniversityEmployee;
public class University
{
    public List<UniversityEmployee> Employees { get; set; }
    public List<Building> Buildings { get; set; }
    public Rector Rector { get; set; }

    public University(List<UniversityEmployee> employees, List<Building> buildings, Rector rector)
    {
        Employees = employees;
        Buildings = buildings;
        Rector = rector;
    }

    public bool AddEmployee(UniversityEmployee employee)
    {
        if (Employees.Contains(employee))
        {
            return false;
        }
        Employees.Add(employee);
        return true;
    }
}

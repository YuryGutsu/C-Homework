

namespace UniversityEmployee;

public class University
{
    public List<UniversityEmployee> Employees;
    public List<Building> Buildings;
    public Rector Rector;

    public University(List<UniversityEmployee> employees, List<Building> buildings, Rector rector)
    {
        Employees = employees;
        Buildings = buildings;
        Rector = rector;
    }
    public bool AddEmployee (UniversityEmployee employee)
    {
        foreach (var item in Employees)
        {
            if (item.Equals(employee))
            {
                return false;
            }
        }
        Employees.Add(employee);
        return true;
    }
}

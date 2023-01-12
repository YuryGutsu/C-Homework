

namespace UniversityEmployee;

internal class University
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
}

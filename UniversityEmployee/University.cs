

namespace UniversityEmployee;

internal class University
{
    public List<University> UniversityEmployees;
    public List<Building> Buildings;
    public UniversityEmployee Rector;

    public University(List<University> employees, List<Building> buildings, UniversityEmployee rector)
    {
        UniversityEmployees = employees;
        Buildings = buildings;
        Rector = rector;
    }

}

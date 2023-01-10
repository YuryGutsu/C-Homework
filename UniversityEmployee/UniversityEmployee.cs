

namespace UniversityEmployee;

internal class UniversityEmployee
{
    public string Person { get; set; }
    public string TaxID { get; set; }

    public UniversityEmployee (string person, string taxID)
    {
        Person = person;
        TaxID = taxID;
    }

    public virtual string GetOfficialDuties()
    {
        return "I'm " + Person + " " + "ID#" + TaxID;
    }

}

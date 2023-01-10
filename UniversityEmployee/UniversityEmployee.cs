

namespace UniversityEmployee;

internal class UniversityEmployee
{
    public Person Person { get; set; }
    public string TaxID { get; set; }

    public UniversityEmployee (Person person, string taxID)
    {
        Person = person;
        TaxID = taxID;
    }

    public virtual string GetOfficialDuties()
    {
        return $"I'm {Person} ID# {TaxID}";
    }

}

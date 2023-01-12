

namespace UniversityEmployee;

abstract class UniversityEmployee
{
    public Person Person { get; set; }
    public string TaxId { get; set; }

    public UniversityEmployee (Person person, string taxId)
    {
        Person = person;
        TaxId = taxId;
    }

    public virtual string GetOfficialDuties()
    {
        return $"I'm {Person} ID# {TaxId}";
    }
}
namespace UniversityEmployee;

public abstract class UniversityEmployee
{
    public Person Person { get; set; }
    public string TaxId { get; set; }

    public UniversityEmployee(Person person, string taxId)
    {
        Person= person;
        TaxId = taxId;
    }

    public virtual string GetOfficialDuties()
    {
        return $"I'm {Person} ID# {TaxId}";
    }
    public override bool Equals(object obj)
    {
        if (obj == null || obj is not UniversityEmployee employee)
        {
            return false;
        }

        return employee.TaxId.Equals(TaxId)
            && employee.Person.Equals(Person);
    }

    public override int GetHashCode()
    {
        return TaxId.GetHashCode() + Person.GetHashCode();
    }
}
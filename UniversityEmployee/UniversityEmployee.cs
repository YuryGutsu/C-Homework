namespace UniversityEmployee;

public abstract class UniversityEmployee : IComparable<UniversityEmployee>
{
    private string _taxId;
    public Person Person { get; set; }
    public string TaxId
    {
        get
        {
            return _taxId;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid TaxId");
            }
            _taxId = value;
        }
    }

    public UniversityEmployee(Person person, string taxId)
    {
        Person = person;
        TaxId = taxId;
    }

    public virtual string GetOfficialDuties()
    {
        return $"I'm {Person} ID# {TaxId}";
    }

    public override bool Equals(object? obj)
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

    public int CompareTo(UniversityEmployee? other)
    {
        return other.Person.FullNameLength() - this.Person.FullNameLength();
    }
}
namespace UniversityEmployee;

public class Rector : UniversityEmployee
{ 
    public string RectorOfWhat { get; set; }
    
    public Rector(Person person, string taxId, string rectorOfWhat) : base (person, taxId)
    {
    RectorOfWhat = rectorOfWhat;
    }

    public override string GetOfficialDuties()
    {
        return $"{base.GetOfficialDuties()} rector of {RectorOfWhat}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not Rector rector)
        {
            return false;
        }

        return base.Equals(obj) && rector.RectorOfWhat.Equals(RectorOfWhat);
    }

    public override int GetHashCode()
    {
        return RectorOfWhat.GetHashCode();
    }

}


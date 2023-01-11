

namespace UniversityEmployee;

internal class Rector : UniversityEmployee
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

}


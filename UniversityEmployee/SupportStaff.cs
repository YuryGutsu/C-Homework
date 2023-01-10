

namespace UniversityEmployee;

internal class SupportStaff : UniversityEmployee
{
    public string StaffDuty { get; set; }

    public SupportStaff(Person person, string taxID, string staffDuty) : base (person, taxID)
    {
        StaffDuty = staffDuty;
    }

    public override string GetOfficialDuties()
    {
        return $"{base.GetOfficialDuties()} {StaffDuty}";
    }
}

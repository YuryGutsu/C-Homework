

namespace UniversityEmployee;

internal class SupportStaff : UniversityEmployee
{
    public string StaffDuty { get; set; }

    public SupportStaff(Person person, string taxId, string staffDuty) : base (person, taxId)
    {
        StaffDuty = staffDuty;
    }

    public override string GetOfficialDuties()
    {
        return $"{base.GetOfficialDuties()} {StaffDuty}";
    }
}

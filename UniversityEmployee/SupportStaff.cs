

namespace UniversityEmployee;

public class SupportStaff : UniversityEmployee
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
    public override bool Equals(object obj)
    {
        if (obj == null || obj is not SupportStaff supportStaff)
        {
            return false;
        }

        return base.Equals(obj) && supportStaff.StaffDuty.Equals(StaffDuty);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}

using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]
public class SupportStaffTest
{
    [TestMethod]
    public void TestOverrideGetOfficialDutiesPositive()
    {
        SupportStaff staff = new SupportStaff(new Person("Dddd", "Mnnn"), "GG1989", "Gggg");
        string getOfficialDuties = "I'm Dddd Mnnn ID# GG1989 Gggg";
        Assert.AreEqual(staff.GetOfficialDuties(), getOfficialDuties);
    }
}
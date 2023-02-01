using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]
public class SupportStaffTest
{
    [TestMethod]
    public void TestStaffOverrideGetOfficialDutiesPositive()
    {
        SupportStaff staff = new SupportStaff(new Person("Dddd", "Mnnn"), "GG1989", "Gggg");
        string getOfficialDuties = "I'm Dddd Mnnn ID# GG1989 Gggg";
        Assert.AreEqual(staff.GetOfficialDuties(), getOfficialDuties);
    }

    [TestMethod]
    public void TestStaffEqualsPositive()
    {
        SupportStaff staff = new SupportStaff(new Person("dddd", "mMMM"), "gg1989", "guard");
        SupportStaff s = new SupportStaff(new Person("dddd", "mMMM"), "gg1989", "guard");
        Assert.AreEqual(staff, s);
    }

    [TestMethod]
    public void TestStaffEqualsNegative()
    {
        SupportStaff staff = new SupportStaff(new Person("DDDD", "mMMM"), "gg1989", "guard");
        SupportStaff s = new SupportStaff(new Person("dddd", "mMMM"), "gg1989", "guard");
        Assert.AreNotEqual(staff, s);
    }

}
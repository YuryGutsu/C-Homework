using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class RectorTest
{
    Rector rector = new Rector(
        new Person("Taras", "Bulba"),
        "RR1111",
        "BGUIR");

    [TestMethod]
    public void TestRectorOverrideGetOfficialDutiesPositive()
    {
        string getOfficialDuties = "I'm Taras Bulba ID# RR1111 rector of BGUIR";
        Assert.AreEqual(rector.GetOfficialDuties(), getOfficialDuties);
    }

    [TestMethod]
    public void TestRectorEqualsPositive()
    {
        var rec = new Rector(
               new Person("Taras", "Bulba"),
               "RR1111",
               "BGUIR");
        Assert.AreEqual(rector, rec);
    }

    [TestMethod]
    public void TestRectorEqualsNegative()
    {
        var rec = new Rector(
               new Person("Taras", "Bulba"),
               "RR1111",
               "BGU");
        Assert.AreNotEqual(rector, rec);
    }
}

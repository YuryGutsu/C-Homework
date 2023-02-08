using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]
public class TeacherWithDegreeTest
    {
    TeacherWithDegree teacher = new TeacherWithDegree(
        new Person("Sara", "White"),
        "AB3333",
        new Course("Biology", "Pathology"),
        "Magistr", "Rector");

    [TestMethod]
    public void TestTeacherWithDegreeOverrideGetOfficialDutiesPositive()
    {
        string getOfficialDuties = "I'm Sara White ID# AB3333 teacher of Biology Pathology Magistr Rector";
        Assert.AreEqual(teacher.GetOfficialDuties(), getOfficialDuties);
    }

    [TestMethod]
    public void TestTeacherWithDegreeEqualsPositive()
    {
        var t = new TeacherWithDegree(
                new Person("Sara", "White"),
                "AB3333",
                new Course("Biology", "Pathology"),
                "Magistr", "Rector");
        Assert.AreEqual(teacher, t);
    }

    [TestMethod]
    public void TestTeacherWithDegreeEqualsNegative()
    {
        var t = new TeacherWithDegree(
                new Person("Sara", "White"),
                "AB3333",
                new Course("Biology", "Pathology"),
                "MAGISTR", "Rector");
        Assert.AreNotEqual(teacher, t);
    }
}


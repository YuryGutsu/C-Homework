using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]
public class TeacherTest
{
    Teacher teacher = new Teacher(
        new Person("Dan", "Spencer"),
        "AB2223",
        new Course("Math", "Algebra"));

    [TestMethod]
    public void TestTeacherOverrideGetOfficialDutiesPositive()
    {
        string getOfficialDuties = "I'm Dan Spencer ID# AB2223 teacher of Math Algebra";
        Assert.AreEqual(teacher.GetOfficialDuties(), getOfficialDuties);
    }

    [TestMethod]
    public void TestTeacherEqualsPositive()
    {
        var t = new Teacher(
                new Person("Dan", "Spencer"),
                "AB2223",
                new Course("Math", "Algebra"));
        Assert.AreEqual(teacher, t);
    }

    [TestMethod]
    public void TestTeacherEqualsNegative()
    {
        var t = new Teacher(
                new Person("Dan", "Spencer"),
                "AAAAAA",
                new Course("Math", "Algebra"));
        Assert.AreNotEqual(teacher, t);
    }
}

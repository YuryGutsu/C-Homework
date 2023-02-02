using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]
public class TeacherTest
{
    [TestMethod]
    public void TestTeacherOverrideGetOfficialDutiesPositive()
    {
        var teacher = new Teacher(
                new Person("Dan", "Spencer"),
                "AB2223",
                new Course("Math", "Algebra"));
        string getOfficialDuties = "I'm Dan Spencer ID# AB2223 teacher of Math Algebra";
        Assert.AreEqual(teacher.GetOfficialDuties(), getOfficialDuties);
    }

    [TestMethod]
    public void TestTeacherEqualsPositive()
    {
        var teacher = new Teacher(
                new Person("Dan", "Spencer"),
                "AB2223",
                new Course("Math", "Algebra"));
        var t = new Teacher(
                new Person("Dan", "Spencer"),
                "AB2223",
                new Course("Math", "Algebra"));
        Assert.AreEqual(teacher, t);
    }

    [TestMethod]
    public void TestTeacherEqualsNegative()
    {
        var teacher = new Teacher(
                new Person("Dan", "Spencer"),
                "AB2223",
                new Course("Math", "Algebra"));
        var t = new Teacher(
                new Person("Dan", "Spencer"),
                "AAAAAA",
                new Course("Math", "Algebra"));
        Assert.AreNotEqual(teacher, t);
    }
}

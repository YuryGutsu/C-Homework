using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]
public class TeacherTest
{
    [TestMethod]
    public void TestTeacherOverrideGetOfficialDutiesPositive()
    {
        Teacher teacher = new Teacher(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("courseName", "courseDescribtion"));
        string getOfficialDuties = "I'm Dddd Mnnn ID# GG1989 teacher of courseName courseDescribtion";
        Assert.AreEqual(teacher.GetOfficialDuties(), getOfficialDuties);
    }

    [TestMethod]
    public void TestTeacherEqualsPositive()
    {
        Teacher teacher = new Teacher(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("courseName", "courseDescribtion"));
        Teacher t = new Teacher(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("courseName", "courseDescribtion"));
        Assert.AreEqual(teacher, t);
    }

    [TestMethod]
    public void TestTeacherEqualsNegative()
    {
        Teacher teacher = new Teacher(new Person("Dddd", "Mnnn"),
                         "GG1989",
                         new Course("courseName", "courseDescribtion"));
        Teacher t = new Teacher(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("222", "courseDescribtion"));
        Assert.AreNotEqual(teacher, t);
    }
}

using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class PersonTest
{
    Person person = new Person("Bob", "Dylan");

    [TestMethod]
    public void TestPersonsEqualsPositive()
    {
        var p = new Person(null, "Dylan");
        Assert.AreEqual(person, p);
    }

    [TestMethod]
    public void TestPersonsFirstNameEqualsNegative()
    {
        var p = new Person("BBB", "Dylan");
        Assert.AreNotEqual(person, p);
    }

    [TestMethod]
    public void TestPersonsLastNameEqualsNegative()
    {
        var p = new Person("BBB", "DDDDD");
        Assert.AreNotEqual(person, p);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestPersonFullNameLengthThrowsException()
    {
        var p = new Person("BobBobBobBobBobBob", "Dilan");
    }
}

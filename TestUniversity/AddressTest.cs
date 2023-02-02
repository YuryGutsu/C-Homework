using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class AddressTest
{
    [TestMethod]
    public void TestNumberOfBuildingThrowsException()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Address("Minsk", "ul. Brovki", 1001));
        Assert.AreEqual("incorrect value NumberOfBuilding, it must be > 0 and <= 1000", ex.Message);
    }

    [TestMethod]
    public void TestAddressesEqualsPositive()
    {
        var address = new Address("Minsk", "ul. Brovki", 1);
        var a = new Address("Minsk", "ul. Brovki", 1);
        Assert.AreEqual(address, a);
    }

    [TestMethod]
    public void TestAddressesEqualsNegative()
    {
        var address = new Address("Minsk", "ul. Brovki", 1);
        var a = new Address("Orsha", "ul. Brovki", 1);
        Assert.AreNotEqual(address, a);
    }
}

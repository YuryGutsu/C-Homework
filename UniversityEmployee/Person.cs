namespace UniversityEmployee;

public class Person
{
    private string _firstName;
    private string _lastName;
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            CheckFullNameLength(value, _lastName);
            _firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            CheckFullNameLength(value, _firstName);
            _lastName = value;
        }
    }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public void CheckFullNameLength(string value, string name)
    {
        ArgumentNullException.ThrowIfNull(value);
        if (value.Length + (name?.Length ?? 0) > 15)
        {
            throw new ArgumentException("FirstName and LastName length must be <=15");
        }
    }

    public int FullNameLength()
    {
        return FirstName.Length + LastName.Length;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not Person person)
        {
            return false;
        }
        return person.FirstName.Equals(FirstName)
            && person.LastName.Equals(LastName);
    }

    public override int GetHashCode()
    {
        return FirstName.GetHashCode() + LastName.GetHashCode();
    }
}

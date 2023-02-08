namespace UniversityEmployee;

public class Person
{
    /*private string _firstName;
    private string _lastName;
    public string FirstName
    {
        get
        {
            return _firstName;
        }
        set
        {
            
            if (value.Length + _lastName.Length > 15)
            {
                throw new ArgumentException("FirstName and LastName length must be <=15");
            }
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
            if (value.Length + _firstName.Length > 15)
            {
                throw new ArgumentException("FirstName and LastName length must be <=15");
            }
            _lastName = value;
        }
    }*/
    public string FirstName { get; set; }
    public string LastName { get; set; } 

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        if (FullNameLength() > 15)
        {
            throw new ArgumentException("FirstName and LastName length must be <=15");
        }
    }

    /*private static void CheckFullNameLength(string firstName, string lastName)
    {
        if (firstName.Length + lastName.Length > 15)
        {
            throw new ArgumentException("FirstName and LastName length must be <=15");
        }
    }*/

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

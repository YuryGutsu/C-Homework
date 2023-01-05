using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysNew
{
    internal class Person
    {
        public string FirstName { get; }
        public string LastName { get; }
        public Address Address { get; }

        public Person(string firstName, string lastName, Address address)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
        }
    }
}

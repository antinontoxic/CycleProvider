using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider
{
    public class PersonBuilder
    {
        private readonly Person _person;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }

        public PersonBuilder()
        {
            FirstName = "Automation";
            LastName = "Automation-Last_Name";
            BirthDate = DateTime.Now.AddYears(-20);
        }

        public PersonBuilder WithFirstName(string firstName)
        {
            FirstName = firstName;
            return this;
        }

        public PersonBuilder WithLastName(string lastName)
        {
            LastName = lastName;
            return this;
        }

        public PersonBuilder WithBirthDate(int year, int month, int day)
        {
            BirthDate = new DateTime(Math.Abs(year), month < 1 ? 1 : month > 12 ? 12 : month, day);
            return this;
        }

        public PersonBuilder WithBirthDate(DateTime birthDate)
        {
            BirthDate = birthDate;
            return this;
        }

        public PersonBuilder WithPersonProperities(PersonBuilder person)
        {
            FirstName = person.FirstName;
            LastName = person.LastName;
            BirthDate = person.BirthDate;
            return this;
        }

        public Person Build()
        {
            return new Person(LastName)
            {
                FirstName = FirstName,
                BirthDate = BirthDate
            };
        }
    }
}

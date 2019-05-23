using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CycleProvider.Contracts;

namespace CycleProvider
{
    public abstract class PersonBase : IPerson
    {
        public static int Counter = 0;

        public int Id { get; }
        public abstract string FirstName { get; set; }
        public abstract string LastName { get; set; }
        public abstract DateTime BirthDate { get; set; }

        public PersonBase(string LastName)
        {
            Id = ++Counter;
        }

        public override string ToString()
        {
            return $"Person {Id} of {Counter} => {LastName} {FirstName} was born in {BirthDate}";
        }

        protected virtual void CalculateAge()
        {

        }
    }
}

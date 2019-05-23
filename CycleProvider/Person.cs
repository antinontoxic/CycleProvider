using CycleProvider.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider
{
    public class Person : PersonBase
    {
        public Person(string lastName) : base(lastName)
        {
            LastName = lastName ?? throw new HrException($"Person can not be created without {nameof(LastName)}");
        }

        public override string FirstName { get; set; }
        public override string LastName { get; set; }
        public override DateTime BirthDate { get; set; }

        protected override void CalculateAge()
        {
            base.CalculateAge();
        }
    }
}

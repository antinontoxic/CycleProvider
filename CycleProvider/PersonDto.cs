using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider
{
    public class PersonDto
    {
        private readonly PersonBase _personBase;

        public int Id { get => _personBase.Id; }
        public DateTime BirthDate { get => _personBase.BirthDate; }

        public PersonDto(PersonBase personBase)
        {
            _personBase = personBase;
        }
    }
}

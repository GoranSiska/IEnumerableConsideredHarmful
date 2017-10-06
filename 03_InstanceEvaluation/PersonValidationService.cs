using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_InstanceEvaluation
{
    public class PersonValidationService
    {
        public bool HaveErrors(IEnumerable<PersonDto> personDtos)
        {
            var persons = From(personDtos)
               //.ToList()
               ;

            Validate(persons);

            return persons.Any(p=>p.HasError);
        }

        public IEnumerable<Person> From(IEnumerable<PersonDto> personDtos)
        {
            return personDtos.Select(personDto => new Person
            {
                Name = personDto.Name
            });
        }

        public void Validate(IEnumerable<Person> persons)
        {
            foreach (var person in persons)
            {
                if (person.Name.Any(char.IsDigit))
                {
                    person.HasError = true;
                }
            }
        }
      
    }
}

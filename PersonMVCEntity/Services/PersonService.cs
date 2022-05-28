using PersonMVCEntity.Models;
using System.Collections.Generic;
using System.Linq;

namespace PersonMVCEntity.Services
{
    public class PersonService
    {
        List<Person> people;

        public PersonService()
        {
            people = new List<Person>
            {
                new Person { Name = "Sandra", City = "Goteborg", PhoneNumber = "072312323" },
                new Person { Name = "Emma", City = "Gotebrg", PhoneNumber = "42343424" },
                new Person { Name = "Jhon", City = "Stockhom", PhoneNumber = "072232323" }
            };
        }

        //public IEnumerable<Person> GetAll()
        // {
        //     return people;
        // }

        public IEnumerable<Person> GettAllPersonByName(string SearchTearm)
        {
            return from r in people
                   //where string.IsNullOrEmpty(search) || r.Name.StartsWith(search)
                   where string.IsNullOrEmpty(SearchTearm) || r.Name.Contains(SearchTearm)
                   orderby r.Name
                   select r;
        }

        public Person AddPerson(Person person)
        {
            people.Add(person);

            return person;
        }
    }
}

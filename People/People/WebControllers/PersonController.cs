using System.Collections.Generic;
using People.ModelsDB;
using People.Repositories;

namespace People.WebControllers
{
    public class PersonController
    {
        private readonly IPersonRepository _personRepository;

        public PersonController(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public List<Person> GetAllPeople()
        {
            return _personRepository.FindAll();
        }

        public Person GetPersonById(int personId)
        {
            return _personRepository.FindById(personId);
        }

        public ExitCode AddPerson(Person person)
        {
            return _personRepository.Add(person);
        }

        public ExitCode UpdatePerson(Person person)
        {
            return _personRepository.Update(person);
        }

        public ExitCode DeletePersonById(int personId)
        {
            return _personRepository.DeleteById(personId);
        }
    }
}

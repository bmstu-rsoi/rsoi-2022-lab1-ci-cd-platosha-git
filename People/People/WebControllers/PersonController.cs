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
    }
}
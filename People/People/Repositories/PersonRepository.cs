using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Logging;
using People.ModelsDB;

namespace People.Repositories
{
    public class PersonRepository : IPersonRepository, IDisposable
    {
        private readonly PeopleContext _db;
        private readonly ILogger<PersonRepository> _logger;

        public PersonRepository(PeopleContext createDB, ILogger<PersonRepository> logDB)
        {
            _db = createDB;
            _logger = logDB;
        }

        public List<Person> FindAll()
        {
            List<Person> people = _db.People.ToList();
            return people;
        }

        public Person FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ExitCode Add(Person obj)
        {
            throw new NotImplementedException();
        }

        public ExitCode Update(Person obj)
        {
            throw new NotImplementedException();
        }

        public ExitCode DeleteById(int id)
        {
            throw new NotImplementedException();
        }
        
        public void Dispose()
        {
            _db.Dispose();
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using People.ModelsBL;
using People.ModelsDB;

namespace People.Repositories
{
    public class PersonRepository : IPersonRepository, IDisposable
    {
        private readonly personContext _db;
        private readonly ILogger<PersonRepository> _logger;
        
        public void Dispose()
        {
            _db.Dispose();
        }

        public List<PersonBL> FindAll()
        {
            throw new NotImplementedException();
        }

        public PersonBL FindById(int id)
        {
            throw new NotImplementedException();
        }

        public ExitCode Add(PersonBL obj)
        {
            throw new NotImplementedException();
        }

        public ExitCode Update(PersonBL obj)
        {
            throw new NotImplementedException();
        }

        public ExitCode DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
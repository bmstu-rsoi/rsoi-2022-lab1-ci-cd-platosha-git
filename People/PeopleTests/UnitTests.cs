using System.Collections.Generic;
using People.Repositories;
using People.ModelsDB;
using People.WebControllers;
using Xunit;
using Moq;

namespace PeopleTests
{
    public class UnitTests
    {
        [Fact]
        public void FindAll_NotNull()
        {
            var expPerson = new PersonBuilder().Build();
            var expPeople = new List<Person>() {expPerson};

            var mock = new Mock<IPersonRepository>();
            mock.Setup(x => x.FindAll())
                .Returns(expPeople);
            var personController = new PersonController(mock.Object);

            var actPeople = personController.GetAllPeople();
            
            Assert.NotNull(expPeople);
            Assert.Equal(expPeople, actPeople);
        }
        
        [Fact]
        public void FindById_FirstElement_NotNull()
        {
            const int personId = 1;
            
            var expPerson = new PersonBuilder()
                .WherePersonId(personId)
                .Build();
            
            var mock = new Mock<IPersonRepository>();
            mock.Setup(x => x.FindById(personId))
                .Returns(expPerson);
            var personController = new PersonController(mock.Object);
            
            var actPerson = personController.GetPersonById(personId);
            
            Assert.NotNull(expPerson);
            Assert.Equal(expPerson, actPerson);
        }
        
        [Fact]
        public void FindByAge_NotNull()
        {
            const int age = 23;
            
            var expPerson = new PersonBuilder()
                .WhereAge(age)
                .Build();
            var expPeople = new List<Person>() {expPerson};

            var mock = new Mock<IPersonRepository>();
            mock.Setup(x => x.FindByAge(age))
                .Returns(expPeople);
            var personController = new PersonController(mock.Object);
            
            var actPeople = personController.GetPeopleByAge(age);
            
            Assert.NotNull(expPeople);
            Assert.Equal(expPeople, actPeople);
        }
    }
}
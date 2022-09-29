using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using People.WebControllers;
using People.ModelsDB;
using People.ModelsDTO;

namespace People.APIControllers
{
    [ApiController]
    [Route("/api/v1/persons")]
    public class ApiPersonController : ControllerBase
    {
        private readonly PersonController _personController;

        public ApiPersonController(PersonController personController)
        {
            _personController = personController;
        }
        
        private List<PersonDTO> ListPersonDTO(List<Person> people)
        {
            var peopleDTO = new List<PersonDTO>();
            foreach (var person in people)
            {
                var personDTO = new PersonDTO(person);
                peopleDTO.Add(personDTO);
            }

            return peopleDTO;
        }
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Person>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllPeople()
        {
            List<Person> people = _personController.GetAllPeople();
            if (people.Count == 0)
            {
                return NoContent();
            }

            List<PersonDTO> lPersonDTO = ListPersonDTO(people);
            return Ok(lPersonDTO);
        }
    }
}

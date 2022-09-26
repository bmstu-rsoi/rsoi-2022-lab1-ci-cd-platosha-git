using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using People.WebControllers;
using People.ModelsDB;

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
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Person>))]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllFood()
        {
            List<Person> people = _personController.GetAllPeople();
            if (people.Count == 0)
            {
                return NoContent();
            }

            List<FoodDTO> lFoodDTO = ListFoodDTO(people);
            return Ok(lFoodDTO);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using People.WebControllers;

namespace People.APIControllers
{
    [ApiController]
    [Route("/api/v1/persons")]
    public class ApiPersonController : ControllerBase
    {
        private readonly PersonController _personController;
    }
}

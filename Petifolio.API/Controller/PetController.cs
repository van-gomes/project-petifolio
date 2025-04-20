using Microsoft.AspNetCore.Mvc;
using Petifolio.Comunication.Request;
using Petifolio.Comunication.Response;

namespace Petifolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
    public IActionResult Register([FromBody] RequestRegisterPetJson request)
    {
        //business logic
        
        return Created();
    }
}
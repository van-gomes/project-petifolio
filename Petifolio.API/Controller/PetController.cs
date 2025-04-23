using Microsoft.AspNetCore.Mvc;
using Petifolio.Aplication.UseCases.Pet.Register;
using Petifolio.Comunication.Request;
using Petifolio.Comunication.Response;

namespace Petifolio.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseRegisterPetJson), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseErrorJason), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RequestRegisterPetJson request)
    {
        //business logic
        var response = new RegisterPetUseCase().Execute(request);
        
        return Created(string.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorJason), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] int id, [FromBody] RequestRegisterPetJson request)
    {
        return NoContent();
    }
}
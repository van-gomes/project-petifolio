using Microsoft.AspNetCore.Mvc;
using Petifolio.Aplication.UseCases.Pet.GetAll;
using Petifolio.Aplication.UseCases.Pet.GetById;
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
    
    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllPetJason), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll()
    {
        var useCase = new GetAllPetsUseCase();
        
        var response = useCase.Execute();

        if (response.Pets.Any())
        {
            return Ok(response);
        }
        
        return NoContent();
    }
    
    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponsePetJason), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetById(int id)
    {
        var useCase = new GetPetByIdUseCase();
        
        var response = useCase.Execute(id);
        
        return Ok(response);
    }
}
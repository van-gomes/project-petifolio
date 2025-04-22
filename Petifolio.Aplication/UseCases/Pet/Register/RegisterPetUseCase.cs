using Petifolio.Comunication.Request;
using Petifolio.Comunication.Response;

namespace Petifolio.Aplication.UseCases.Pet.Register;

public class RegisterPetUseCase
{
    public ResponseRegisterPetJson Execute(RequestRegisterPetJson request)
    {
        return new ResponseRegisterPetJson
        {
            Id = 17,
            Name = request.Name
        };
    }
}
using Petifolio.Comunication.Request;

namespace Petifolio.Aplication.UseCases.Pet.Register;

public class RegisterPetUseCase
{
    public RequestRegisterPetJson Execute(RequestRegisterPetJson request)
    {
        return new RequestRegisterPetJson
        {
            Id = 17,
            Name = request.Name
        };
    }
}
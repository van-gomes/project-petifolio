using Petifolio.Comunication.Response;

namespace Petifolio.Aplication.UseCases.Pet.GetById;

public class GetPetByIdUseCase
{
    public ResponsePetJason Execute(int id)
    {
        return new ResponsePetJason
        {
            Id = id,
            Name = "Rex",
            Type = Comunication.Enum.PetType.Cat,
            Birthday = new DateTime(year: 2021, month: 1, day: 1)
        };
    }
}
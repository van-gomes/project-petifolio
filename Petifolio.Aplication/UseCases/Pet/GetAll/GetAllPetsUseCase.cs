using Petifolio.Comunication.Response;

namespace Petifolio.Aplication.UseCases.Pet.GetAll;

public class GetAllPetsUseCase
{
    public ResponseAllPetJason Execute()
    {
        return new ResponseAllPetJason()
        {
            /*Pets = new List<ResponseShortPetJason>
            {
                new ResponseShortPetJason
                {
                    Id = 1,
                    Name = "Rex",
                    Type = Comunication.Enum.PetType.Dog
                }
            }*/
        };
    }
}
using Petifolio.Comunication.Enum;

namespace Petifolio.Comunication.Request;

public class RequestRegisterPetJson
{
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetType Type { get; set; }
}
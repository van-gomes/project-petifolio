using Petifolio.Comunication.Enum;

namespace Petifolio.Comunication.Response;

public class ResponseShortPetJason
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public PetType Type { get; set; }
}
using Petifolio.Comunication.Enum;

namespace Petifolio.Comunication.Response;

public class ResponsePetJason
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Birthday { get; set; }
    public PetType Type { get; set; }
}

namespace Domain;

public class Address
{
    public int AddressId { get; set; }
    public string Description { get; set; } = null!;
    
    public int StudentId { get; set; }
    public int StateId { get; set; }
}

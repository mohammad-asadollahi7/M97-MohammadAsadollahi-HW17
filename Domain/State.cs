namespace Domain;

public class State
{
    public int StateId { get; set; }
    public string Name { get; set; } = null!;
    public IEnumerable<Address> Addresses { get; set; }
}

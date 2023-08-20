namespace Domain.Entites;

public class State : BaseEntity
{
    public int StateId { get; set; }
    public string Name { get; set; }
    public IEnumerable<Address> Addresses { get; set; }
}

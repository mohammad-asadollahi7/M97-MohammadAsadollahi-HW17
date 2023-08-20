
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain;

public class Address : BaseEntity
{
    public int AddressId { get; set; }
    public string Description { get; set; } 

    [ForeignKey(nameof(Student))]
    public int StudentId { get; set; }

    [ForeignKey(nameof(State))]
    public int StateId { get; set; }
}

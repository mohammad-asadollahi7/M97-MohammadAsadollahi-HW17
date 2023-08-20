
namespace Domain;

public class Student
{
    public int StudentId { get; set; }
    public string Name { get; set; } = null!;
    public string Family { get; set; } = null!;
    public string FatherName { get; set; } = null!;

    public Address? Address { get; set; }
    public IEnumerable<Course>? Coureses { get; set; }
}

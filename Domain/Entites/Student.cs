namespace Domain.Entites;

public class Student : BaseEntity
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string FatherName { get; set; }

    public Address? Address { get; set; }
    public IEnumerable<Course>? Courses { get; set; }
}

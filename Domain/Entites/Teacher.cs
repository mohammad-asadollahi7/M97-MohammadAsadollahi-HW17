namespace Domain.Entites;

public class Teacher : BaseEntity
{
    public int TeacherId { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public IEnumerable<Course>? Courses { get; set; }
}

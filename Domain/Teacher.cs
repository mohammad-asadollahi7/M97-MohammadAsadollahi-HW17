
namespace Domain;

public class Teacher
{
    public int TeacherId { get; set; }
    public string Name { get; set; } = null!;
    public string Family { get; set; } = null!;
    public IEnumerable<Course>? Courses { get; set; }
}

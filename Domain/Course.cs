
namespace Domain;

public class Course
{
    public int CourseId { get; set; }
    public string Name { get; set; } = null!;
    public int Unit { get; set; }

    public Teacher? Teacher { get; set; }
    public IEnumerable<Student>? students { get; set; }
}

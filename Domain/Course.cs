
namespace Domain;

public class Course : BaseEntity
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public int Unit { get; set; }

    public Teacher? Teacher { get; set; }
    public IEnumerable<Student>? Students { get; set; }
}



using Domain.Entites;

namespace Application.Dtos;

public class StudentsWithCoursesDto
{
    public int StudentId { get; set; }
    public string Name { get; set; }
    public string Family { get; set; }
    public string FatherName { get; set; }

    public IEnumerable<Course>? Courses { get; set; }
}

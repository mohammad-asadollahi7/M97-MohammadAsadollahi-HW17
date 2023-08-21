
using System.Reflection.Metadata.Ecma335;

namespace Application.Dtos;

public class CourseWithStudentCountDto
{
    public int CourseId { get; set; }
    public string Name { get; set; }
    public int Unit { get; set; }
    public int Count { get; set; }
}

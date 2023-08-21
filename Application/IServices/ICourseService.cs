
using Application.Dtos;

namespace Application.IServices;

public interface ICourseService
{
    IEnumerable<CourseWithStudentCountDto> GetAllWithStudentCounts(); 
}

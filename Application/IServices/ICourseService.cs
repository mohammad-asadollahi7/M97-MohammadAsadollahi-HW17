
using Application.Dtos;
using Domain.Entites;

namespace Application.IServices;

public interface ICourseService
{
    IEnumerable<Course> GetAll();
    IEnumerable<CourseWithStudentCountDto> GetAllWithStudentCounts(); 
    
}

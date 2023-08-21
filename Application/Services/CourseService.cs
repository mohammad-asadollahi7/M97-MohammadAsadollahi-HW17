using Application.Dtos;
using Application.IServices;
using Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class CourseService : ICourseService
{
    private readonly ICourseRepository _courseRepository;

    public CourseService(ICourseRepository courseRepository)
    {
        _courseRepository = courseRepository;
    }
    public IEnumerable<CourseWithStudentCountDto> GetAllWithStudentCounts()
    {
        var courses = _courseRepository.GetAll().Include(c => c.Students);

        var courseWithCount = courses.Select(c => new CourseWithStudentCountDto
        {
            CourseId = c.CourseId,
            Name = c.Name,
            Unit = c.Unit,
            Count = c.Students.Count()
        }).OrderBy(c => c.Name);
        return courseWithCount.ToList(); 
    }
}

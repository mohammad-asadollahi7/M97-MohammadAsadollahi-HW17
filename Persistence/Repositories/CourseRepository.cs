

using Domain.Entites;
using Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class CourseRepository : ICourseRepository
{
    private readonly ApplicationContext _context;

    public CourseRepository(ApplicationContext context)
    {
        _context = context;
    }
    public IQueryable<Course> GetAll()
    {
       return _context.Courses.AsQueryable();
    }
}

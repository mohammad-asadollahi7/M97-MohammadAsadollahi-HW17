using Domain.Entites;
using Domain.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories;

public class StudentRepository : IStudentRepository
{
    private readonly ApplicationContext _context;

    public StudentRepository(ApplicationContext context)
    {
        _context = context;
    }

    public IQueryable<Student> GetAll()
    {
        return _context.Students.AsQueryable();
    }
   
}

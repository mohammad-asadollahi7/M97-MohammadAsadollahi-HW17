
using Domain.Entites;

namespace Domain.IRepositories;

public interface IStudentRepository
{
    IQueryable<Student> GetAll();
}

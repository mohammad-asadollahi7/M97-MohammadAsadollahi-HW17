

using Domain.Entites;

namespace Domain.IRepositories;

public interface ICourseRepository
{
    IQueryable<Course> GetAll();
}


using Application.Dtos;
using Application.IServices;
using Domain.Entites;
using Domain.IRepositories;
using Mapster;
using System.Drawing;

namespace Application.Services;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }
    public IEnumerable<StudentsWithCoursesDto> GetAllWithCourses()
    {
        var students = _studentRepository.GetAllWithCourses();
        if (students == null)
        {
            throw new Exception();
        }

        var stuWithCourse = new List<StudentsWithCoursesDto>();

        foreach (var student in students)
        {
            stuWithCourse.Add(
              new StudentsWithCoursesDto()
            {
                StudentId = student.StudentId,
                Name = student.Name,
                Family = student.Family,
                FatherName = student.FatherName,
                Courses = student.Courses
            });
         }

        return stuWithCourse;
    }
}


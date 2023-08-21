using Microsoft.EntityFrameworkCore;
using Application.Dtos;
using Application.IServices;
using Domain.Entites;
using Domain.IRepositories;
using Mapster;
using System.Drawing;
using System.Reflection;

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
        var students = _studentRepository.GetAll().Include(c => c.Courses);
        if (students == null)
            throw new Exception();

        return MapToDto(students);
    }

    public IEnumerable<StudentsWithCoursesDto> GetAllWithTeachers()
    {
        var students = _studentRepository.GetAll().Include(c => c.Courses)
                            .ThenInclude(c => c.Teacher);
        if (students == null)
            throw new Exception();

        return MapToDto(students);
    }
    private IEnumerable<StudentsWithCoursesDto> MapToDto(IQueryable<Student> students)
    {
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



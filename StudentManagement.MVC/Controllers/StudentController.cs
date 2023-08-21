using Application.IServices;
using Domain.IRepositories;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.MVC.Controllers;

public class StudentController : Controller
{
    private readonly IStudentService _studentService;

    public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpGet]
    public IActionResult GetAllWithCourses()
    {
        var students = _studentService.GetAllWithCourses();
        return View(students);
    }

    [HttpGet]
    public IActionResult GetAllWithTeachers()
    {
        var students = _studentService.GetAllWithTeachers();
        return View(students);
    }

    [HttpGet]
    public IActionResult GetAllWithExceptCourses([FromServices] ICourseService courseService)
    {
        var students = _studentService.GetAllWithCourses();
        var allCourses = courseService.GetAll();

        foreach (var student in students)
        {
             student.Courses = allCourses.Except(student.Courses);
        }
        return View(students);

    }

    [HttpGet]
    public IActionResult GetAllWithStateName()
    {
        var students = _studentService.GetAllWithStateName();
        return View(students);
    }
}

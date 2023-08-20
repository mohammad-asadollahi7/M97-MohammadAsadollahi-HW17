using Application.IServices;
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
}

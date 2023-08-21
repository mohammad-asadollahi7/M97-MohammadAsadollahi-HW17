using Application.IServices;
using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.MVC.Controllers;

public class CourseController : Controller
{
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult GetAllWithStudentCounts()
    {
        var courses = _courseService.GetAllWithStudentCounts();
        return View(courses);   
    }
}

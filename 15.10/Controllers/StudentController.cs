using _15._10.Models;
using Microsoft.AspNetCore.Mvc;

namespace _15._10.Controllers;

public class StudentController : Controller
{
    private Student _student = new Student
    {
        DateOfBirthday = DateTime.Now,
        FirtsName = "test_1",
        LastName = "test_2",
        GPA = 5
    };


    public IActionResult GetStudents()
    {

        //ViewBag.Student = _student;
        //ViewData["Student"] = _student;

        return View(_student);
    }
}

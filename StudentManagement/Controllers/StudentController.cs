using Microsoft.AspNetCore.Mvc;
using StydentManagementSystem1.Data;
using StydentManagementSystem1.Models;

namespace StydentManagementSystem1.Controllers
{
    public class StudentController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.course = StudentData.GetAll();
            return View();

        }
        [HttpGet]
        public IActionResult Add()
        {

            return View();

        }
        [HttpPost]
        [Route("/Student/Add")]
        public IActionResult NewStudent(Student newStudent)
        {
            StudentData.Add(newStudent);

            return Redirect("/Student");
        }
        public IActionResult Delete()
        {
            ViewBag.student = StudentData.GetAll();

            return View();
        }
        [HttpPost]
        public IActionResult Delete(int[] studentIds)
        {
            foreach (int courseId in studentIds)
            {
                CourseData.Remove(courseId);
            }

            return Redirect("/Course");
        }
    }
}

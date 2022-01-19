
using Microsoft.AspNetCore.Mvc;
using StydentManagementSystem1.Data;
using StydentManagementSystem1.Models;
using System.Collections.Generic;

namespace StydentManagementSystem1.Controllers
{
    public class CourseController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {

            ViewBag.course = CourseData.GetAll();
            return View();

        }
        [HttpGet]
        public IActionResult Add()
        {

            return View();

        }
        [HttpPost]
        [Route("/Course/Add")]
        public IActionResult NewCourse(Course newCourse)
        {
            CourseData.Add(newCourse);

            return Redirect("/Course");
        }
        public IActionResult Delete()
        {
            ViewBag.course = CourseData.GetAll();

            return View();
        }
        [HttpPost]
        public IActionResult Delete(int[] courseIds)
        {
            foreach (int courseId in courseIds)
            {
                CourseData.Remove(courseId);
            }

            return Redirect("/Course");
        }
        public IActionResult Edit(int courseId)
        {
            ViewBag.course = CourseData.GetAll();

            return View();
        }
        [HttpPost]
        public IActionResult SubmitEditEventForm(int courseId, string courseName, string description)
        {

            return View();

        }
    }
}

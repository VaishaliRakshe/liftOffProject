
using Microsoft.AspNetCore.Mvc;
using StudentManagement.ViewModels;
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

            List<Course>course = new List<Course>(CourseData.GetAll());
            return View(course);

        }
        [HttpGet]
        public IActionResult Add()
        {
            AddCourseViewModel addCourseViewModel = new AddCourseViewModel();
            return View(addCourseViewModel);

        }
        [HttpPost]
        
        public IActionResult Add(AddCourseViewModel addCourseViewModel)
        {
            Course newCourse = new Course
            {
                CourseName=addCourseViewModel.CourseName,
                Description=addCourseViewModel.Description
            };
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


    
       
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement.Data;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860



namespace StudentManagement.Controllers
{
    public class CourseController : Controller
    {
        private DbContext context;

        public CourseController(DbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {



            return View();

        }
        public IActionResult Adds()
        {


            AddCourseViewModel addEventViewModel = new AddCourseViewModel();
            return View(addEventViewModel);
        }


        //[HttpPost]
        //public IActionResult Add(AddCourseViewModel addCourseViewModel)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        Course theCategory = context.Find(addCourseViewModel.CourseId);
        //       Course newEvent = new Course
        //        {

        //            CourseID = AddCourseViewModel.CourseId,

        //            CourseTitle = AddCourseViewModel.CourseTitle,
        //           Description = AddCourseViewModel.Description

        //        };


        //        context.Course.Add(newCourse);
        //        context.SaveChanges();
        //        return Redirect("/Course");
        //    }

        //    return View(addCourseViewModel);
        //}
        //public IActionResult Delete()
        //{
        //    ViewBag.course = context.Course.ToList();
        //    return View();
        //}
        [HttpPost]
        //public IActionResult Delete(int[] eventIds)
        //{
        //    foreach (int eventId in eventIds)
        //    {

        //        Event theEvent = context.Events.Find(eventId);
        //        context.Events.Remove(theEvent);
        //    }
        //    context.SaveChanges();
        //    return Redirect("/Events");
        //}
        //public IActionResult Detail(int id)
        //{
        //    Event theEvent = context.Events
        //       .Include(e => e.Category)
        //       .Single(e => e.Id == id);
        //    List<EventTag> eventTags = context.EventTags
        //    .Where(et => et.EventId == id)
        //    .Include(et => et.Tag)
        //    .ToList();

        //    EventDetailViewModel viewModel = new EventDetailViewModel(theEvent, eventTags);
        //    return View(viewModel);
        //}
        //public IActionResult Edit(int eventId)
        //{
        //    // controller code will go here
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult SubmitEditEventForm(int eventId, string name, string description)
        //{
        //    // controller code will go here
        //    return View();
        //}

    }
}

using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace StudentManagement.Controllers
{
    public class StudentRegisrtationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

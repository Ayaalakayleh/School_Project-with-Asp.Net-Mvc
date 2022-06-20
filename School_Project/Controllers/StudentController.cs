using Microsoft.AspNetCore.Mvc;

namespace School_Project.Controllers
{
    public class StudentController : Controller
    {
        public ActionResult Index() // handles GET requests by default
        {
            return View();
        }

    }
}

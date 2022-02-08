using Microsoft.AspNetCore.Mvc;

namespace Demo23_WebApp.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return Ok("hello world from ASP.NET");
        }
    }
}

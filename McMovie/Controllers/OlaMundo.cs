using Microsoft.AspNetCore.Mvc;

namespace McMovie.Controllers
{
    public class OlaMundo : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

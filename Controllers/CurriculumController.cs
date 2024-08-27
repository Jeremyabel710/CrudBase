using Microsoft.AspNetCore.Mvc;

namespace CrudBase.Controllers
{
    public class CurriculumController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

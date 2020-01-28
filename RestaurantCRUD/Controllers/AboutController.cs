using Microsoft.AspNetCore.Mvc;

namespace RestaurantCRUD.Controllers
{
    public class AboutController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}
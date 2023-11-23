using Microsoft.AspNetCore.Mvc;

namespace TheMask.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }
    }
}

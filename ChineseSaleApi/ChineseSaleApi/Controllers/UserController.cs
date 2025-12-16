using Microsoft.AspNetCore.Mvc;

namespace ChineseSaleApi.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
            }
    }
}

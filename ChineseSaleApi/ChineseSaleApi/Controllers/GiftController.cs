using Microsoft.AspNetCore.Mvc;

namespace ChineseSaleApi.Controllers
{
    public class GiftController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

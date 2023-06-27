using Demo.Models.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.greeting = "Xin chào";
            ViewData["greeting2"] = "Tôi đang sử dụng view data";
            TempData["greeting3"] = " Nó là dữ liệu tạm thời";
            return View();
        }

        public IActionResult AddPerson()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddPerson(Person person)
        {
            return View();
        }

    }
}

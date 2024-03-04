using ArticleWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Article.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(UserInformationModel User)
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}

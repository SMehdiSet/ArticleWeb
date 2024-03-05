using Article.Data;
using ArticleWeb.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Article.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public UserController(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }

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
            if (ModelState.IsValid)
            {

                _applicationDbContext.UserInformationDb.Add(User);
                _applicationDbContext.SaveChanges();

                return RedirectToAction("Acount");
            }
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Acount()
        {
            return View();
        }
    }
}

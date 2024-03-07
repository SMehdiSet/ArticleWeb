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

                return RedirectToAction("Acount", User.Id);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserLoginModel User)
        {
            if (ModelState.IsValid)
            {
                Guid Id = Guid.Empty;
                foreach(var user in _applicationDbContext.UserInformationDb)
                {
                    if (user.UserName == User.UserName &&  user.Password == User.Password)
                    {
                        Id = user.Id;
                    }
                }
                return RedirectToAction("Acount", Id);
            }
            return View();
        }

        [HttpGet]
        public IActionResult Acount(Guid Id)
        {
            var user = _applicationDbContext.UserInformationDb.Find(Id);
            return View(user);
        }

        [HttpPost]
        public IActionResult Acount(UserInformationModel User)
        {
            if (ModelState.IsValid)
            {
                _applicationDbContext.UserInformationDb.Update(User);
                _applicationDbContext.SaveChanges();

                return View();
            }
            return RedirectToAction("Login");
        }
    }
}

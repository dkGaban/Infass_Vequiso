using Infass_Vequiso.Models;
using Microsoft.AspNetCore.Mvc;

namespace Infass_Vequiso.Controllers
{
    public class LoginController : Controller
    {
        User user = new User();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string Username, string Password)
        {
            string[] fields =
            {
                "Username",
                "Password"
            };

            object[] values =
            {
                Username,
                Password
            };

            string query = user.getloginquery(fields, values, "User");

            return Json(new { success = true, query = query });
        }
    }
}

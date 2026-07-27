using Infass_Vequiso.Models;
using Microsoft.AspNetCore.Mvc;

namespace Infass_Vequiso.Controllers
{
    public class RegisterController : Controller
    {
        User user = new User();

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(
            string FullName,
            string Email,
            string Gender,
            int Age,
            string Address,
            string Username,
            string Password)
        {
            string[] fields =
            {
                "FullName",
                "Email",
                "Gender",
                "Age",
                "Address",
                "Username",
                "Password"
            };

            object[] values =
            {
                FullName,
                Email,
                Gender,
                Age,
                Address,
                Username,
                Password
            };

            string query = user.getquery(fields, values, "User");

            return Json(new { success = true, query = query });
        }
    }
}

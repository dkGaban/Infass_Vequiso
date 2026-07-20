using Infass_Vequiso.Models;
using Microsoft.AspNetCore.Mvc;

namespace Infass_Vequiso.Controllers
{
    public class RegisterController : Controller
    {
        private static List<User> _users = new List<User>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                var error = ModelState.Values
                    .SelectMany(v => v.Errors)
                    .Select(e => e.ErrorMessage)
                    .FirstOrDefault();

                return Json(new { success = false, message = error });
            }

            _users.Add(user);

            return Json(new
            {
                success = true,
                data = new
                {
                    user.FullName,
                    user.Email,
                    user.Gender,
                    user.Age,
                    user.Address,
                    user.Username
                }
            });
        }
    }
}

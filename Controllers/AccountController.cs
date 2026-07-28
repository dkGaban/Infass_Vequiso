using Infass_Vequiso.Models;
using Infass_Vequiso.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Infass_Vequiso.Controllers
{
    [Route("")]
    public class AccountController : Controller
    {
        [HttpGet("Login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost("Login")]
        public IActionResult Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
                return View(model);

            return RedirectToAction("Index", "Home");
        }

        [HttpGet("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost("Register")]
        public IActionResult Register(RegisterViewModel model)
        {
            User user = new User();

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

            string[] values =
            {
                model.FullName,
                model.Email,
                model.Gender,
                model.Age.ToString(),
                model.Address,
                model.Username,
                model.Password
            };

            string sql =
                user.SqlInsert(
                    fields,
                    values,
                    "User"
                );

            return Content(sql);
        }

        [HttpPost("Update")]
        public IActionResult Update(
            RegisterViewModel model,
            string id)
        {
            User user = new User();

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

            string[] values =
            {
                model.FullName,
                model.Email,
                model.Gender,
                model.Age.ToString(),
                model.Address,
                model.Username,
                model.Password
            };

            string sql =
                user.SqlUpdate(
                    fields,
                    values,
                    "User",
                    "Id",
                    id
                );

            return Content(sql);
        }

        [HttpPost("Delete")]
        public IActionResult Delete(string id)
        {
            User user = new User();

            string sql =
                user.SqlDelete(
                    "User",
                    "Id",
                    id
                );

            return Content(sql);
        }

        [HttpGet("ViewAll")]
        public IActionResult ViewAll()
        {
            User user = new User();

            string sql =
                user.ViewAll("User");

            return Content(sql);
        }
    }
}

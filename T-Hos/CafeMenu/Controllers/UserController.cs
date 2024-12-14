using CafeMenu.Models;
using DAL.Entity;
using DAL.Operations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CafeMenu.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(UserModel user)
        {
            if (ModelState.IsValid)
            {
                var userName = user.Username;
                var password = user.HashPassword;
                var operations = UserOperations.GetInstance();
                bool isMatch = operations.LoginAuthenticateUser(userName, password);
                if(isMatch)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, userName),
                        new Claim(ClaimTypes.Role, "User")
                    };

                    var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var authProperties = new AuthenticationProperties();

                    await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity), authProperties);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("HashPassword", "Kullanıcı Adı ve ya şifreniz hatalı.");
                }

            }
            return View();

        }

        public JsonResult CreateUser(string _name, string _surname, string _username, string _password)
        {
            try
            {
                var operations = UserOperations.GetInstance();
                var user = operations.CreateUser(_name, _surname, _username, _password);
                


                GenericRepository<User> repository = new GenericRepository<User>();
                var result = repository.Create(user);

                var userModel = new DAL.Models.UserModel()
                {
                    Id = result.Id,
                    Name = result.Name,
                    Surname = result.Surname,
                    Username = result.Username,
                    HashPassword = result.HashPassword,
                    SaltPassword = result.SaltPassword

                };


                return Json(userModel);
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public JsonResult LoginAuthenticator(string _username, string _password)
        {
            var operations = UserOperations.GetInstance();
            bool isMatch = operations.LoginAuthenticateUser(_username, _password);
            if (isMatch)
            {
                
            }

            return Json(isMatch);

        }
    }
}

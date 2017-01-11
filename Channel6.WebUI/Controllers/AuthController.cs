/*using Channel6.Domain.Entities;
using Channel6.Domain.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using Channel6.Domain.Functions;
using System.Data.Entity;

namespace Channel6.WebUI.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        // GET: Auth
        [HttpGet]
        public ActionResult Index()
        {
            var db = new EFDbContext();
            return View(db.Lists.Where(x => x.Public == "YES").ToList());
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User model)
        {
            if (!ModelState.IsValid) // checks if input fields have the correct format
            {
                return View(model); // returns the view with the input values so that the user doesn't have to retype again
            }

            using (var db = new EFDbContext())
            {
                User user = db.Users.FirstOrDefault(u => u.Email == model.Email);

                try
                {
                    if (model.Email != null && user != null && PasswordStorage.VerifyPassword(model.Password, user.Password))
                    {
                        var identity = new ClaimsIdentity(new[] {
                            new Claim(ClaimTypes.Name, user.Name),
                            new Claim(ClaimTypes.Email, user.Email),
                            new Claim(ClaimTypes.Country, user.Country)
                        },
                            "ApplicationCookie");

                        var ctx = Request.GetOwinContext();
                        var authManager = ctx.Authentication;

                        authManager.SignIn(identity);

                        user.LastLogin = DateTime.Now;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();

                        return RedirectToAction("Index", "Home");
                    }
                }
                catch (InvalidHashException message)
                {
                    ModelState.AddModelError("", message);
                    return View(model); //Should always be declared on the end of an action method
                }
            }

            ModelState.AddModelError("", "Invalid email or password");
            return View(model); //Should always be declared on the end of an action method
        }

        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Login", "Auth");
        }

        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registration(User model)
        {
            if (ModelState.IsValid)
            {
                using (var db = new EFDbContext())
                {
                    var queryUser = db.Users.FirstOrDefault(u => u.Email == model.Email);
                    if (queryUser == null)
                    {
                        var user = db.Users.Create();
                        user.Email = model.Email;
                        user.Country = model.Country;
                        user.Name = model.Name;
                        user.Password = PasswordStorage.CreateHash(model.Password);
                        user.Status = UserStatus.Registered;
                        user.RegisterDateTime = DateTime.Now;
                        db.Users.Add(user);
                        db.SaveChanges();
                    }
                    else
                    {
                        return RedirectToAction("Registration");
                    }
                }
            }
            return View();
        }
    }
}
*/
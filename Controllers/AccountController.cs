using System.Web.Mvc;

namespace ASPNET_MVC_Internship.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account/Login
        public ActionResult Login()
        {
            return View();
        }

        // POST: Account/Login
        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            // Simple hardcoded user check for demo purposes
            if (username == "admin" && password == "password")
            {
                Session["User"] = username;
                return RedirectToAction("Index", "Products");
            }
            ViewBag.Error = "Invalid credentials";
            return View();
        }

        // GET: Account/Logout
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}

using ProjectOne.DAL;
using ProjectOne.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ProjectOne.Controllers
{
    public class HomeController : Controller
    {
        private DegreeContext db = new DegreeContext();

        //This method calls up my landing page
        public ActionResult Index()
        {
            return View();
        }

        //This method calls up my about page
        public ActionResult About()
        {
            ViewBag.Message = "What is Information Systems?";

            return View();
        }

        //This method calls up my contact view
        public ActionResult Contact()
        {
            ViewBag.Message = "Still have questions?";

            return View();
        }

        //This method calls up my Degrees view
        public ActionResult Degrees()
        {
            ViewBag.Message = "Your degrees page";

            return View();
        }

        //This method calls up a dynamically created view depending on if the user selects BSIS or MISM
        [Authorize]
        public ActionResult SelectedDegree(string degree)
        {
            if (degree == "BSIS")
            {
                ViewBag.Title = "BSIS";
                ViewBag.DegreeName = "Bachelors of Science Information Systems";
                ViewBag.Coordinator = "Degree Coordinator: Dr. Albrecht";
                ViewBag.ProfTitle = "Professor";
                ViewBag.OfficeAddress = "780 TNRB";
                ViewBag.PhDEducation = "Doctor of Philosophy, Management Management Information Systems Department | University of Arizona, 2000";
                ViewBag.MastersEd = "Masters of Accountancy, School of Accountancy and Information Systems | Brigham Young University, 1997";
                ViewBag.BachelorsEd = "Bachelors of Science, School of Acountancy and Information Systems | Brigham Young University, 1997";
                ViewBag.TheirPic = Url.Content("/Content/Images/Dr Albrecht.jpg");        
            }

            else if (degree == "MISM")
            {
                ViewBag.Title = "MISM";
                ViewBag.DegreeName = "Masters of Information Systems Management";
                ViewBag.Coordinator = "Degree Coordinator: Dr. Anderson";
                ViewBag.ProfTitle = "Associate Professor";
                ViewBag.OfficeAddress = "776 TNRB";
                ViewBag.PhDEducation = "PhD, Information Systems, Carnegie Mellon University, 2001";
                ViewBag.MastersEd = "MPhil, Public Policy, Carnegie Mellon, 2000";
                ViewBag.MastersEd2 = "MAcc, Information Systems, Brigham Young University, 1995";
                ViewBag.BachelorsEd = "BS, Accounting | Brigham Young University, 1995";
                ViewBag.TheirPic = Url.Content("/Content/Images/Bonnie.jpg");  
            }



            return View();
        }


        //Login Method
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Users account, FormCollection form, int? id, bool rememberMe = false)
        {
            Session["degrees"] = id;
            //Session["userID"] = userid;

            using (DegreeContext db = new DegreeContext())
            {
                //var usr = db.user.Single(u => u.userEmail = account.userEmail && u.uPassword == account.uPassword).FirstOrDefault;
                var usr = db.User.Where(Users => Users.Email == account.Email && Users.Password == account.Password).FirstOrDefault();
                if (usr != null)
                {
                    Session["UserID"] = usr.UserID.ToString();
                    Session["username"] = usr.Email.ToString();
                    FormsAuthentication.SetAuthCookie(usr.Email, rememberMe);
                    return RedirectToAction("Degrees", "Home", new { id = Session["degrees"], userid = Session["UserID"] });
                    // return RedirectToAction("Index", "MissionQuestions", new { id = Session["mission"] });

                }
                else
                {
                    ModelState.AddModelError(" ", "Username or password is wrong. ");
                    // return RedirectToAction("Index");
                }


            }
            return View();


        }


        //Register Method will allow the user to create a new account by entering their email and a password
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Register(Users account, bool bRememberMe = false)
        {
            if (ModelState.IsValid)
            {
                db.User.Add(account);
                db.SaveChanges();

                ModelState.Clear();
                Session["UserID"] = account.UserID;
                Session["Username"] = account.Email;
                FormsAuthentication.SetAuthCookie(account.Email.ToString(), bRememberMe);

                return RedirectToAction("Degrees");
            }

            return View();
        }

    }
}
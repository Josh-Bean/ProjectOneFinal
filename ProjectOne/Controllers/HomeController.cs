using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectOne.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is Information Systems?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Still have questions?";

            return View();
        }

        public ActionResult Degrees()
        {
            ViewBag.Message = "Your degrees page";

            return View();
        }

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

    }
}
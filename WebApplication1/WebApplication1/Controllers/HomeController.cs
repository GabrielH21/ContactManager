using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CityList(int StateCode) {
            IQueryable cities = City.GetCities().Where(x => x.StateCode == StateCode);

            if (HttpContext.Request.IsAjaxRequest()) {
                return Json(new SelectList(
                    cities,
                    "StateCode",
                    "CityID",
                    "CityName"), JsonRequestBehavior.AllowGet
                    );
            }
            return View(cities);
        }

        public ActionResult StateList() {
            IQueryable states = State.GetStates();

            if (HttpContext.Request.IsAjaxRequest()) {
                return Json(new SelectList(
                    states,
                    "StateCode",
                    "StateName"), JsonRequestBehavior.AllowGet
                    );
            }
            return View(states);
        }
    }
}
 
    

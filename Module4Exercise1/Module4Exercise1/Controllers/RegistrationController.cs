using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Module4Exercise1.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult New(NewRegistrationForm form)
        {
          if (!form.PasswordsMatch) 
            {
                ModelState.AddModelError("ConfirmPassword", "Passwords Do Not Match.");
            }
          
          if (ModelState.IsValid) {
                return Redirect("/registered.htm");
            }

          else {
                var errorMessages = ModelState
                    .SelectMany(s => s.Value.Errors)
                    .Select(e => e.ErrorMessage);
                return View("Error", errorMessages);
            }
        }

        public class NewRegistrationForm {
            [Required]
            public string FirstName { get; set;}
            [Required]
            public string LastName { get; set;}
            [Required, RegularExpression(@"^A-Za-z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$")]
            public string EmailAddress { get; set; }
            [Required, RegularExpression("a-zA-z0-9]{5,}", ErrorMessage = "Password must be at least 5 charachters and contain letters and numbers")]
            public string Password { get; set; }
            [Required]
            public string ConfirmPassword { get; set; }
            public string WebsiteUrl { get; set; }

            internal bool PasswordsMatch
            {
                get { return Password == ConfirmPassword; }
            }



        }
    }
}
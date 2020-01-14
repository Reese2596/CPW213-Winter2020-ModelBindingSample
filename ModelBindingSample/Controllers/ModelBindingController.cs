using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class ModelBindingController : Controller
    {
        [HttpGet] //default, not required
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost] //send form data to the server
        public IActionResult Index(Student s)//Dont have to map to class already done for us
        {
            //Ensures our model is in a valid state
            if (ModelState.IsValid) //All requirements check out
            {
                return RedirectToAction("Index", "Home");
            }
            else //Validation problems 
            {
                return View(s);//for the new .Net core you can pass model back to view(s)
                               //but this is now donr automatically by just returning view
            }
        }
    }
}
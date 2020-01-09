using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBindingSample.Models;

namespace ModelBindingSample.Controllers
{
    public class FormsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //When you post data to the server
        //when user clicks submit on form data
        [HttpPost]
        public IActionResult Index(IFormCollection data) 
        {
            //Step 1) Validate all form data
            //Step 2) map form data to C# object
            Student s = new Student();
            s.FullName = data["full-name"];
            s.DateOfBirth = Convert.ToDateTime(data["dob"]);
            s.FavoriteNumber = Convert.ToInt32(data["fav-number"]);
            //Add to the Database

            ViewData["Message"] = "Student Added Successfully";

            return View();
        }
    }
}
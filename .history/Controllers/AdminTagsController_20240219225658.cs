using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Build_a_Blog_With_ASP.NET.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Build_a_Blog_With_ASP.NET.Controllers
{
    
    public class AdminTagsController : Controller
    {
       
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            var name = AddTagRequest.Name;
            var displayName = addTagRequest.;

            return View("Add");
        }

       
    }
}
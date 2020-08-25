using FinalITEAProjects.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Controllers
{
    public class CourseController : Controller
    {
        private ICourseRepository _repository;
        public CourseController(ICourseRepository repository)
        {
            _repository = repository;
                
         }
        public IActionResult View()
        {
            return View();
        }

    }
}

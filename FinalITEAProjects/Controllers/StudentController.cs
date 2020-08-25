using FinalITEAProjects.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository _repository;
        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Get()
        {
            return View();
        }
    }
}

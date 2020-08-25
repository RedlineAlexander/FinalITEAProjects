using FinalITEAProjects.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalITEAProjects.Controllers
{
    public class EnrollmentController :  Controller
    {
        private IEnrollmentRepository _repository;
        public EnrollmentController(IEnrollmentRepository repository)
        {
            _repository = repository;
        }
        public IActionResult Get()
        {
            return View();
        }

    }
}

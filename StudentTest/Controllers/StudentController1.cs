using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentTest.Models;

namespace StudentTest.Controllers
{
    public class StudentController1 : Controller
    {
        private readonly StudentContext _context;

        public StudentController1(StudentContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
